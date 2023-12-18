using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Popups;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BLE_WinFormsApp
{
    public partial class BleForm : Form
    {

        DeviceWatcher deviceWatcher;
        DeviceInformation deviceInformation;
        BluetoothLEDevice bluetoothLeDevice;
        GattDeviceService service;
        GattCharacteristic characteristic;
        object selectedListItem;

        public BleForm()
        {
            InitializeComponent();
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            // Query for extra properties you want returned
            string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected" };

            deviceWatcher =
                         DeviceInformation.CreateWatcher(
                                 BluetoothLEDevice.GetDeviceSelectorFromPairingState(false),
                                 null,
                                 DeviceInformationKind.AssociationEndpoint);

            // Register event handlers before starting the watcher.
            // Added, Updated and Removed are required to get all nearby devices
            deviceWatcher.Added += DeviceWatcher_Added;
            deviceWatcher.Updated += DeviceWatcher_Updated;
            deviceWatcher.Removed += DeviceWatcher_Removed;

            // EnumerationCompleted and Stopped are optional to implement.
            //deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
            //deviceWatcher.Stopped += DeviceWatcher_Stopped;

            //deviceWatcher.Received += DeviceWatcher_Received;

            // Start the watcher.
            deviceWatcher.Start();
        }
        private async void connectButton_Click(object sender, EventArgs e)
        {
            deviceWatcher.Stop();
            // Note: BluetoothLEDevice.FromIdAsync must be called from a UI thread because it may prompt for consent.
            deviceInformation = ((DeviceInformationListItem)selectedListItem).deviceInformation;
            bluetoothLeDevice = await BluetoothLEDevice.FromIdAsync(deviceInformation.Id);
            Debug.WriteLine($"Device connected: {bluetoothLeDevice.Name}");
        }

        private void DeviceWatcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            //throw new NotImplementedException();
        }

        private void DeviceWatcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            //throw new NotImplementedException();
        }

        private void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            Invoke(() => listBox1.Items.Add(new DeviceInformationListItem(args)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedListItem = listBox1.SelectedItem;
            Debug.WriteLine(selectedListItem.ToString());
        }

        private async void listServicesButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var services = await bluetoothLeDevice.GetGattServicesAsync();

            foreach (GattDeviceService service in services.Services)
            {
                listBox1.Items.Add(new GattDeviceServiceListItem(service));
                Debug.WriteLine($"Service UUID: {service.Uuid}");

            }
        }

        private async void listCharactericsButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            service = ((GattDeviceServiceListItem)selectedListItem).service;
            var characteristics = await service.GetCharacteristicsAsync();

            foreach (GattCharacteristic characteristic in characteristics.Characteristics)
            {
                listBox1.Items.Add(new GattCharacteristicListItem(characteristic));
                Debug.WriteLine($"Characteristic UUID: {characteristic.Uuid}");

            }
        }

        private async void writeButton_Click(object sender, EventArgs e)
        {
            characteristic = ((GattCharacteristicListItem)selectedListItem).characteristic;
            await characteristic.WriteValueAsync((Encoding.ASCII.GetBytes("1")).AsBuffer());
        }

        private async void registerNotifyButton_Click(object sender, EventArgs e)
        {
            characteristic = ((GattCharacteristicListItem)selectedListItem).characteristic;
            characteristic.ValueChanged += Characteristic_ValueChanged;
            await characteristic.WriteClientCharacteristicConfigurationDescriptorAsync(
                     GattClientCharacteristicConfigurationDescriptorValue.Notify);
        }

        private void Characteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {                        
            var data = args.CharacteristicValue.ToArray();
            Debug.WriteLine(Encoding.ASCII.GetString(data));

            this.Invoke(new Action(() => MessageBox.Show("Received :" + Encoding.ASCII.GetString(data))));
        }
    }

    public class DeviceInformationListItem
    {
        public DeviceInformation deviceInformation;

        public DeviceInformationListItem(DeviceInformation deviceInformation)
        {
            this.deviceInformation = deviceInformation;
        }

        public override string ToString()
        {
            return $"Name: {deviceInformation.Name} Id:{deviceInformation.Id}";
        }

    }

    public class GattDeviceServiceListItem
    {
        public GattDeviceService service;

        public GattDeviceServiceListItem(GattDeviceService service)
        {
            this.service = service;

        }

        public override string ToString()
        {
            return $"Service UUID: {service.Uuid}";
        }

    }


    public class GattCharacteristicListItem
    {
        public GattCharacteristic characteristic;

        public GattCharacteristicListItem(GattCharacteristic characteristic)
        {
            this.characteristic = characteristic;
        }

        public override string ToString()
        {
            return $"Characteristic UUID: {characteristic.Uuid}";
        }

    }
}