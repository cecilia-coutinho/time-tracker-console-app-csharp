﻿using System.ComponentModel;
using static System.Console;
using static TimeTrackeConsoleApp.MenuSystem;

namespace TimeTrackeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessageScreen();
            DisplayMainMenu();
        }

        static void WelcomeMessageScreen()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(@"");
            WriteLine(@"       .'`~~~~~~~~~~~`'.     ");
            WriteLine(@"       (  .'11 12 1'.  )     ");
            WriteLine(@"       |  :10 \    2:  |     ");
            WriteLine(@"       |  :9   @-> 3:  |     ");
            WriteLine(@"       |  :8       4;  |     ");
            WriteLine(@"       '. '..7 6 5..' .'     ");
            WriteLine(@"        ~-------------~      ");
            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(@"      ____________________ ");
            WriteLine(@"     |                    |");
            WriteLine(@"     |     WELCOME TO     |");
            WriteLine(@"     |  TIME TRACKER APP  |");
            WriteLine(@"     |____________________|");
            ResetColor();
            WriteLine("\n      Press ENTER to Start");
            ReadLine();
        }

        public static void BannerMessageScreen()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(@"         ____________________ ");
            WriteLine(@"        |                    |");
            WriteLine(@"        |  TIME TRACKER APP  |");
            WriteLine(@"        |____________________|");
            ResetColor();
        }

        static void DisplayMainMenu()
        {
            Thread.Sleep(20);
            string menuName = "Main Menu";
            List<MenuSystem> mainMenuItems = new()
            {
                new MenuSystem("Manage Person", ManagePersonMenu),
                new MenuSystem("Manage Project", ManageProjectMenu),
                new MenuSystem("Manage Time Entry", ManageTimeEntryMenu),
                new MenuSystem("View Reports", ViewReportsMenu),
                new MenuSystem("Exit", Exit)
            };
            RunMenu(menuName, mainMenuItems);
        }

        public static void ManagePersonMenu()
        {
            string menuName = "Manage Person Menu";
            List<MenuSystem> managePersonMenuItems = new()
            {
                new MenuSystem("Create New Person", PersonData.AddPerson),
                new MenuSystem("Edit Person", PersonData.UpdatePerson),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, managePersonMenuItems);
        }

        static void ManageProjectMenu()
        {
            string menuName = "Manage Project Menu";
            List<MenuSystem> manageProjectMenuItems = new()
            {
                new MenuSystem("Create New Project", ProjectData.AddProject),
                new MenuSystem("Edit Project", ProjectData.UpdateProject),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, manageProjectMenuItems);
        }

        static void ManageTimeEntryMenu()
        {
            string menuName = "Manage Time Entry Menu";
            List<MenuSystem> manageTimeEntryMenuItems = new()
            {
                new MenuSystem("Create Time Entry", TimeEntryData.CreateTimeEntry),
                new MenuSystem("Edit Time Entry", TimeEntryData.UpdateTimeEntry),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, manageTimeEntryMenuItems);
        }

        static void ViewReportsMenu()
        {
            string menuName = "View Report Menu";
            List<MenuSystem> viewReportsMenuItems = new()
            {
                new MenuSystem("View Persons Report", PersonReportMenu),
                new MenuSystem("View Projects Report", ProjectReportMenu),
                new MenuSystem("View Time Entries Report", TimeEntryReportMenu),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, viewReportsMenuItems);
        }

        static void PersonReportMenu()
        {
            string menuName = "Person Report Menu";

            List<MenuSystem> PersonReportsMenuItems = new()
            {
                new MenuSystem("Display All Persons", PersonData.DisplayAllPersons),
                new MenuSystem("Display Persons By Project", PersonData.DisplayPersonsListByProject),
                new MenuSystem("Return to Previous Menu", ViewReportsMenu),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, PersonReportsMenuItems);
        }

        static void ProjectReportMenu()
        {
            string menuName = "Project Report Menu";

            List<MenuSystem> ProjectReportsMenuItems = new()
            {
                new MenuSystem("Display All Projects", ProjectData.DisplayAllProjects),
                new MenuSystem("Display Projects By Person", ProjectData.DisplayProjectsListByPerson),
                new MenuSystem("Return to Previous Menu", ViewReportsMenu),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, ProjectReportsMenuItems);
        }

        static void TimeEntryReportMenu()
        {
            string menuName = "Time Entry Report Menu";
            List<MenuSystem> TimeEntryReportsMenuItems = new()
            {
                new MenuSystem("Display All Time Entries By Person", TimeEntryData.DisplayAllTimeEntriesByPerson),
                new MenuSystem("Display All Time Entries By Project", TimeEntryData.DisplayAllTimeEntriesByProject),
                new MenuSystem("Return to Previous Menu", ViewReportsMenu),
                new MenuSystem("Return to Main Menu", DisplayMainMenu)
            };
            RunMenu(menuName, TimeEntryReportsMenuItems);
        }
        static void Exit()
        {
            Clear();
            WriteLine("\n\tThank you for using the App. We look forward to your next visit!");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}