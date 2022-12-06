using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.UI.Core;

namespace BLE_WinFormsApp
{
    public partial class BleForm : Form
    {

        DeviceWatcher deviceWatcher;
        DeviceInformation deviceInformation;
        BluetoothLEDevice bluetoothLeDevice;
        GattDeviceService service;
        GattCharacteristic characteristic;

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
        private void connectButton_Click(object sender, EventArgs e)
        {

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