using System;

class Program
{
    static void Main(string[] args)
    {
        
    }

    abstract class SmartDevice
    {
        private bool _IsOn;
        private string _name;
        private DateTime _startTime;
        public abstract void toggleOnOrOff();

        public TimeSpan GetOnDuration()
        {
            if (_isOn)
            {
                return DateTime.Now - _startTime;
            }
            else
            {
                return TimeSpan.Zero;
            }
        }
    }

    public class SmartLight : SmartDevice
    {
        private int _wattage;

        public override void toggleOnOrOff()
        {
            _isOn = !_isOn;
        }
    }

    public class SmartHeater : SmartDevice
    {
        private int _temperature;
        public override void toggleOnOrOff()
        {
            if (_isOn == true)
            {
                _isOn = false;
            }

            else
            {
                _isOn = true;
            }
        }
    }

    public class SmartTV : SmartDevice
    {
        private float _pixelCount;

        public override void toggleOnOrOff()
        {
            if (_isOn == true)
            {
                _isOn = false;
            }

            else
            {
                _isOn = true;
            }
        }
    }

    public class House
    {
        private List<Room> _rooms;
    }

    public class Room
    {
        private List<SmartDevice> _devices;

        public void ToggleLights()
        {
            foreach (SmartDevice device in _devices)
            {

            }
        }

        public void ToggleOneDevice(SmartDevice device)
        {
            device.toggleOnOrOff();
        }

        public void ToggleAllDevices()
        {
            foreach (SmartDevice device in _devices)
            {
                device.toggleOnOrOff();
            }
        }

        public void ReportAllDevices()
        {
            foreach (SmartDevice device in _devices)
            {
                Console.WriteLine($"{device._name}: {device._IsOn}");
            }
        }

        public void ReportLongestDevice()
        {
            foreach (SmartDevice device in _devices)
            {
                device.
                DateTime.Compare
            }
        }

    }
}