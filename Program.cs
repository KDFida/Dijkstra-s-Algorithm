using System;
using System.Collections.Generic;
using System.IO;

namespace NEA
{
    class MainClass
    {   
        public static char Reuse;

        /// <summary>
        /// When the subroutine is called,
        /// Menu options will be displayed to the user
        /// </summary>
        public static void DisplayMenuOpt()
        {
            Console.WriteLine("Would you like to: (Please Select a Number) ");
            Console.WriteLine("(1) Navigate Around the College");
            Console.WriteLine("(2) Lost Function");
            Console.WriteLine("(3) Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// When the subroutine is called,
        /// File "DisplayLocations.txt" will be read and
        /// Text in file will be displayed to user
        /// </summary>
        public static void DisplayLocationOpt()
        {
            Console.WriteLine("Select a Number"); 

            string[] lines = System.IO.File.ReadAllLines("DisplayLocations.txt");
            foreach (string str in lines)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// When the subroutine is called,
        /// File "LostLocations.txt" will be read and
        /// Text in file will be displayed to user
        /// </summary>
        public static void DisplayLostLocation()
        {
            string[] lines = System.IO.File.ReadAllLines("LostLocations.txt");
            foreach (string str in lines)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// When the subroutine is called,
        /// User will be dispplyed with an option
        /// To add a stop if they wish to
        /// </summary>
        public static void DisplayStopOpt()
        {
            Console.WriteLine("Would you like to add a stop? ");
            Console.WriteLine("(1) Yes");
            Console.WriteLine("(2) No");
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed for DisplayMenuOpt() option
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetMenuOpt()
        {
            int choice = 0;
            bool number = false;
            while (!number)
            {
                Console.Write("Please enter your choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    while (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number only!");
                }
               
            }
            Console.WriteLine();
            return choice;
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed for DisplayLocationOpt() option
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetCurrentLocationOpt()
        {
            int currentLocation = 0;
            bool number = false;
            while (!number)
            {
                Console.WriteLine("Please Select your Current Location from the list above:");
                try
                {
                    currentLocation = Convert.ToInt32(Console.ReadLine());
                    while (currentLocation < 1 || currentLocation > 13)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        currentLocation = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch 
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
           
            Console.WriteLine();
            return currentLocation;
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed for DisplayStopOpt() option
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetStopOpt()
        {
            int stopOpt = 0;
            bool number = false;
            while (!number)
            {
                Console.Write("Please enter your choice: ");
                try
                {
                    stopOpt = Convert.ToInt32(Console.ReadLine());
                    while (stopOpt < 1 || stopOpt > 2)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        stopOpt = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
           
            return stopOpt;
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed for DisplayLocationOpt() option
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetDestinationLocationOpt()
        {
            int destinationLocation = 0;
            bool number = false;
            while (!number)
            {
                Console.WriteLine("Please Select your Destination Location from the list above:");
                try
                {
                    destinationLocation = Convert.ToInt32(Console.ReadLine());
                    while (destinationLocation < 1 || destinationLocation > 13)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        destinationLocation = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
           
            Console.WriteLine();
            return destinationLocation;
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed for DisplayLocationOpt() option
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetStopLocationOpt()
        {
            int stopLocation = 0;
            bool number = false;
            while (!number)
            {
                Console.WriteLine("Please Select your stop Location from the list above:");
                try
                {
                    stopLocation = Convert.ToInt32(Console.ReadLine());
                    while (stopLocation < 1 || stopLocation > 14)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        stopLocation = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch 
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
            Console.WriteLine();
            return stopLocation;
        }

        /// <summary>
        /// When the subroutine is called,
        /// Integer typed  for lost locations
        /// Will be verified for validation
        /// </summary>
        /// <returns></returns>
        public static int GetLostOpt()
        {
            int lostOpt = 0;
            bool number = false;
            while (!number)
            {
                Console.WriteLine("Please Look Around, What can you see? (Select a Number) ");
                try
                {
                    lostOpt = Convert.ToInt32(Console.ReadLine());
                    while (lostOpt < 1 || lostOpt > 15)
                    {
                        Console.WriteLine("Invalid Selection. Please Try Again!");
                        Console.Write("Please enter your choice: ");
                        lostOpt = Convert.ToInt32(Console.ReadLine());
                    }
                    number = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
            Console.WriteLine();
            return lostOpt;
        }

        /// <summary>
        /// Process of finding
        /// Shortest path when
        /// Start and stop node are same
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="stopNode"></param>
        /// <param name="destinationNode"></param>
        public static void SameStartStop(int startNode, int stopNode, int destinationNode)
        {
            int sameStartStop;
            int sameStopEnd;

            sameStartStop = NodeEqualNode(startNode, stopNode);
            destinationNode = GetDestinationLocationOpt();
            if (sameStartStop == destinationNode)
            {
                sameStopEnd = NodeEqualNode(sameStartStop, destinationNode);
                ShortestPath(startNode, sameStartStop);
                Console.WriteLine("You have reachead the stop location!");
                ShortestPath(sameStartStop, sameStopEnd);
                Console.WriteLine("You have reachead your destination!");
            }
            else
            {
                ShortestPath(startNode, sameStartStop);
                Console.WriteLine("You have reachead the stop location!");
                ShortestPath(sameStartStop, destinationNode);
                Console.WriteLine("You have reachead your destination!");
            }
        }

        /// <summary>
        /// Process of finding
        /// Shortest path when
        /// Stop and stop node are same
        /// Eg. Stop and destination may be same 
        /// </summary>
        public static void SameStopDestination(int startNode, int stopNode, int destinationNode)
        {
            int sameStopEnd;
            destinationNode = GetDestinationLocationOpt();
            if (stopNode == destinationNode)
            {
                sameStopEnd = NodeEqualNode(stopNode, destinationNode);
                ShortestPath(startNode, stopNode);
                Console.WriteLine("You have reachead the stop location!");
                ShortestPath(stopNode, sameStopEnd);
                Console.WriteLine("You have reachead your destination!");
            }
            else
            {
                ShortestPath(startNode, stopNode);
                Console.WriteLine("You have reachead the stop location!");
                ShortestPath(stopNode, destinationNode);
                Console.WriteLine("You have reachead your destination!");
            }
        }

        /// <summary>
        /// Process of finding
        /// Shortest path when
        /// No stops have been selected
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="destinationNode"></param>
        public static void NoStop(int startNode, int destinationNode)
        {
            int sameStartEnd;
            Console.WriteLine("No stops selected");
            destinationNode = GetDestinationLocationOpt();

            if (startNode == destinationNode)
            {
                sameStartEnd = NodeEqualNode(startNode, destinationNode);
                ShortestPath(startNode, sameStartEnd);
                Console.WriteLine("You have reachead your destination!");
            }
            else
            {
                ShortestPath(startNode, destinationNode);
                Console.WriteLine("You have reachead your destination!");
            }
        }

        /// <summary>
        /// When subroutine is called,
        /// It checks if two nodes are identical
        /// If are indentical then
        /// User told to enter different integer
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public static int NodeEqualNode(int node1, int node2)
        {
            bool validation = false;
            Console.WriteLine("Input is invalid.");
            while (!validation)
            {
                try
                {
                    while (node2 == node1)
                    {
                        Console.WriteLine("Please select a different location");
                        node2 = Convert.ToInt32(Console.ReadLine());
                    }
                    validation = true;
                }
                catch 
                {
                    Console.WriteLine("Please enter a number only!");
                }
            }
            Console.WriteLine();
            return node2;
        }

        /// <summary>
        /// Reads File "CollegeAdjMatrix.txt" and stores integers in file into 2D Array
        /// Finds unvisited 'neighbour node' with smallest distance value from start node
        /// Stores the previous node and stores (if needed update) the shortest distance from start node
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="EndNode"></param>
        public static void ShortestPath(int startNode, int EndNode)
        {
            string[] collegeGraph = File.ReadAllLines("CollegeAdjMatrix.txt");

            int row = 0;
            int column = 0;
            int NumberOfNodes = collegeGraph.Length;
            bool[] NodeVisited = new bool[NumberOfNodes];
            int[] Distance = new int[NumberOfNodes];
            int[] Path = new int[NumberOfNodes];

            var graph = File.ReadAllText("CollegeAdjMatrix.txt");
            int[,] graph2D = new int[collegeGraph.Length, collegeGraph.Length];
            foreach (var r in graph.Split('\n'))
            {
                column = 0;
                foreach (var col in r.Split(','))
                {
                    graph2D[row, column] = int.Parse(col);
                    column++;
                }
                row++;
            }

            for (int PositionOfNode = 0; PositionOfNode < NumberOfNodes; PositionOfNode++)
            {
                Distance[PositionOfNode] = int.MaxValue;
                NodeVisited[PositionOfNode] = false;
            }

            Distance[startNode] = 0;
            Path[startNode] = startNode;

            for (int i = 1; i < NumberOfNodes; i++)
            {
                int shortestDistance = int.MaxValue;
                int NeighbourNode = startNode;


                for (int NodePosition = 0; NodePosition < NumberOfNodes; NodePosition++)
                {
                    if (NodeVisited[NodePosition] == false && Distance[NodePosition] < shortestDistance)
                    {
                        shortestDistance = Distance[NodePosition];
                        NeighbourNode = NodePosition;
                    }
                }

                NodeVisited[NeighbourNode] = true;


                for (int NodeIndex = 0; NodeIndex < NumberOfNodes; NodeIndex++)
                {
                    int graphValue = graph2D[NeighbourNode, NodeIndex];
                    int newDistance = shortestDistance + graphValue;

                    if (graphValue > 0 && newDistance < Distance[NodeIndex])
                    {
                        Distance[NodeIndex] = newDistance;
                        Path[NodeIndex] = NeighbourNode;
                    }
                }
            }

            PrintShortestPath(startNode, EndNode, Path);
        }

        /// <summary>
        /// When subroutine called,
        /// Read File "Directions.txt"
        /// Uses stack to print shortest path
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="endNode"></param>
        /// <param name="Path"></param>
        public static void PrintShortestPath(int startNode, int endNode, int[] Path)
        {
            string[] directions = System.IO.File.ReadAllLines("Directions.txt");
            Stack<int> route = new Stack<int>();
            while (endNode != startNode)
            {
                route.Push(endNode);
                endNode = Path[endNode];
            }
            Console.WriteLine("From " + directions[endNode]);
            while (route.Count != 0)
            {
                Console.WriteLine("--> Go to the " + directions[route.Pop()]);
            }
        }

        public static void Main(string[] args)
        {
            int menuOpt;
            int stopSelection;
            int lost;
            int startNode;
            int stopNode;
            int destinationNode = 0;
            bool reuseValidation = false;

            Console.WriteLine("Welcome to Nelson and Colne College!");

            do
            {
                DisplayMenuOpt();
                menuOpt = GetMenuOpt();

                if (menuOpt == 1)
                {
                    DisplayLocationOpt();
                    startNode = GetCurrentLocationOpt();

                    DisplayStopOpt();
                    stopSelection = GetStopOpt();

                    if (stopSelection == 1)
                    {
                        stopNode = GetStopLocationOpt();
                        if (startNode == stopNode)
                        {
                            SameStartStop(startNode, stopNode, destinationNode);
                        }
                        else
                        {
                            SameStopDestination(startNode, stopNode, destinationNode);
                        }
                    }
                    else
                    {
                        NoStop(startNode, destinationNode);
                    }
                }
                else if (menuOpt == 2)
                {
                    DisplayLostLocation();
                    lost = GetLostOpt();

                    string[] lines = System.IO.File.ReadAllLines("FoundLocations.txt");
                    Console.WriteLine(lines[lost]);

                }
                else if (menuOpt == 3)
                {
                    Console.WriteLine("GoodBye!");
                }

                reuseValidation = false;
                Console.WriteLine();
                while (reuseValidation == false)
                {
                    Console.WriteLine("Would you like to use the program again? (Y/N)");
                    try
                    {
                        Reuse = Convert.ToChar(Console.ReadLine());
                        while (Reuse != 'Y' && Reuse != 'N' && Reuse != 'y' && Reuse != 'n')
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N");
                            Console.WriteLine("Would you like to use the program again? (Y/N)");
                            Reuse = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine();
                        }
                        reuseValidation = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter Y or N");
                    }
                }
               
            } while (Reuse != 'N' && Reuse != 'n');

            Console.WriteLine("GoodBye...");
        }

    }
}