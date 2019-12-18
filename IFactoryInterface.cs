namespace factory {
    interface IFacotry {
        int speed {get;set;}
        int numOfDoors {get;set;}
        int horsePower {get;set;}
        int numberOfWindows {get;set;}

        string toString();

    }


    class Pride : IFacotry {
        private int _speed;
        private int _numOfDoors;
        private int _horsePower;
        private int _numberOfWindows; 


        public Pride(int speed,int numOfDoors, int horsePower, int numberOfWindows) {
            _speed = speed;
            _numberOfWindows = numberOfWindows;
            _numOfDoors = numOfDoors;
            _horsePower = horsePower;
        }

        public int speed {
            get {return _speed;}
            set {_speed = value;}
        }

        public int horsePower {
            get {return _horsePower;}
            set {_horsePower = value;}
        }

        public int numberOfWindows {
            get {return _numberOfWindows;}
            set {_numberOfWindows = value;}
        }

        public int numOfDoors {
            get {return _numOfDoors;}
            set {_numOfDoors = value;}
        }

        public string toString() {
            return "speed=" + speed + "\nNumber of Doors=" + numOfDoors + "\nHorse Power=" + horsePower + "\nNumber of Windows=" + numberOfWindows;
        }
    }

        class BMW : IFacotry {
        private int _speed;
        private int _numOfDoors;
        private int _horsePower;
        private int _numberOfWindows; 


        public BMW(int speed,int numOfDoors, int horsePower, int numberOfWindows) {
            _speed = speed;
            _numberOfWindows = numberOfWindows;
            _numOfDoors = numOfDoors;
            _horsePower = horsePower;
        }

        public int speed {
            get {return _speed;}
            set {_speed = value;}
        }

        public int horsePower {
            get {return _horsePower;}
            set {_horsePower = value;}
        }

        public int numberOfWindows {
            get {return _numberOfWindows;}
            set {_numberOfWindows = value;}
        }

        public int numOfDoors {
            get {return _numOfDoors;}
            set {_numOfDoors = value;}
        }

        public string toString() {
            return "speed=" + speed + "\nNumber of Doors=" + numOfDoors + "\nHorse Power=" + horsePower + "\nNumber of Windows=" + numberOfWindows;
        }
    }
}