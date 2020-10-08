// copyright (c) 2020 kathrina branco, VFS, All rights reserved
using System;

namespace Adventure
{
    class Car
    {
        // This definatly doesn't work in my game, no cars it it
        
        // properties
        private string _brand;
        private string _category; // sedan, coupe, truck
        private int    _wheels = 4;
        private string _colour = "green";
        private float  _value; // what does it cost
        private int    _doors = 2;

        private int    _gears = 5;
        private float  _currentspeed = 0.0f;
        private float  _horsepower;
        private float  _torque;
        private float  _mass;
        

        // constructor
        

        //methods
        private void init( string brand, string category )
        {
            // initalize all properties here
            _brand = brand;
            _category = category;
            this._colour = "green";
        }
        public float Accelerate( float throttlePosition )
        {
            // 100: Somehow take the throttle position 0 - 100 and calculate
            // an acceleration
            return 0.0f;
        }

        public float Brake( float brakeforce )
        {
            // 1000: somehow compute a decleration based breaking force
            return 0.0f;
        }
    }
}