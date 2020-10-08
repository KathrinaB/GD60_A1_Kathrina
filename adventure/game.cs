// Copyright (C) 2020 Kathrina Branco,  VFS, All Rights Reserved

using System;

namespace hello
{
       class game
    {
        // local variables(private)
        private Location _CurrentLocation = new Location("The Beguining","You Start Here");

        private map _theGameMap = new map (MAP_Size);

        public void Run()
        {
            // create map
            //load location, location data
            //setup game
        }
        public Void Run()
        {
            Render();
            while(!_gameOver)
        }
        update();
        Render();
    }
}