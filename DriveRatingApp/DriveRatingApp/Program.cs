using System;
using System.Collections.Generic;
using System.Linq;

namespace DriveRatingApp
{
    class Program
    {
        static void Main()
        {
            bool goOn1 = true;
            List<TeamMember> allTeamMembers = TeamMemberRepo.GetTeamMembers();

            Console.Write("Enter your Common ID: ");
            string userCommonId = Console.ReadLine().ToLower();

            if (userCommonId.StartsWith('t'))
            {

                Console.WriteLine($"  , Your current Drive Rating is   and you will receive    as a bonus. ");
                Console.WriteLine();
                Console.WriteLine("Would you like to return to the Main Menu? Enter [1] for yes or [2] to exit: ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Main();
                        break;
                    case 2:

                        break;
                    default:
                        Console.WriteLine("That was an invalid response");
                        break;

                }
            }

            if (userCommonId.StartsWith("l"))
            {
                Console.WriteLine("(1) Update a Team Member's DRIVE rating");
                Console.WriteLine("(2) View the Bonus Report");
                Console.Write("What would you like to do? Enter [1] or [2]: ");
                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        Console.Write("Please enter the Common ID of the Team Member you'd like to update: ");
                        string userUpdateMemeber = Console.ReadLine();
                        if (userUpdateMemeber.StartsWith('l') || userUpdateMemeber.StartsWith('d'))
                        {
                            Console.WriteLine("You do not have permission to update this member.");
                            Console.WriteLine("Would you like to return to the Leader Main Menu? Enter [1] for yes or [2] to return to the main menu: ");
                            int answer2 = int.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    //loop back to main leader menu
                                    break;
                                case 2:
                                    Main();

                                    break;
                                default:
                                    Console.WriteLine("That was an invalid response");
                                    break;

                            }


                            Console.WriteLine("(1) Needs Improvement (2) Achieving Expectation (3) Exceeds Expectations (4) RockStar");
                            Console.Write("What rating would you like to add? ");
                            int userSelectRating2 = int.Parse(Console.ReadLine());
                            if (userSelectRating2 == 1)
                            {
                                var driveRating = DriveRating.NeedsImprovement;
                            }
                            if (userSelectRating2 == 2)
                            {
                                var driveRating = DriveRating.AchievingExpectations;
                            }
                            if (userSelectRating2 == 3)
                            {
                                var driveRating = DriveRating.ExceedExpectations;
                            }
                            if (userSelectRating2 == 4)
                            {
                                var driveRating = DriveRating.RockStar;
                            }

                            foreach (var member in allTeamMembers)
                            {
                                //add rating to list
                            }
                            Console.WriteLine("DRIVE has been updated");

                            break;
                        }
                        Console.WriteLine("(1) Needs Improvement (2) Achieving Expectation (3) Exceeds Expectations (4) RockStar");
                        Console.Write("What rating would you like to add? ");
                        int userSelectRating = int.Parse(Console.ReadLine());
                        if (userSelectRating == 1)
                        {
                            var driveRating = DriveRating.NeedsImprovement;
                        }
                        if (userSelectRating == 2)
                        {
                            var driveRating = DriveRating.AchievingExpectations;
                        }
                        if (userSelectRating == 3)
                        {
                            var driveRating = DriveRating.ExceedExpectations;
                        }
                        if (userSelectRating == 4)
                        {
                            var driveRating = DriveRating.RockStar;
                        }

                        foreach (var member in allTeamMembers)
                        {
                            //add rating to list
                        }
                        Console.WriteLine("DRIVE has been updated");

                        

                        Console.WriteLine("Would you like to return to the Main Menu? Enter [1] for yes or [2] to exit: ");
                        int answer3 = int.Parse(Console.ReadLine());
                        switch (answer3)
                        {
                            case 1:
                                Main();
                                break;
                            case 2:

                                break;
                            

                        }

                        break;
                    case 2:
                        foreach (var member in allTeamMembers)
                        {
                            Console.WriteLine(member);
                        }


                        break;
                    default:
                        Console.WriteLine("That was an invalid response");
                        break;

                }

            }
            if (userCommonId.StartsWith('d'))
            {
                Console.WriteLine("(1) Update a Team Member's DRIVE rating");
                Console.WriteLine("(2) View the Bonus Report");
                Console.Write("What would you like to do? Enter [1] or [2]: ");
                int answer3 = int.Parse(Console.ReadLine());

                switch (answer3)
                {
                    case 1:
                        Console.Write("Please enter the Common ID of the Team Member you'd like to update: ");
                        string userUpdateMemeber = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("(1) Needs Improvement (2) Achieving Expectation (3) Exceeds Expectations (4) RockStar");
                        Console.Write("What rating would you like to add? ");
                        int userSelectRating3 = int.Parse(Console.ReadLine());
                        if (userSelectRating3 == 1)
                        {
                            var driveRating = DriveRating.NeedsImprovement;
                        }
                        if (userSelectRating3 == 2)
                        {
                            var driveRating = DriveRating.AchievingExpectations;
                        }
                        if (userSelectRating3 == 3)
                        {
                            var driveRating = DriveRating.ExceedExpectations;
                        }
                        if (userSelectRating3 == 4)
                        {
                            var driveRating = DriveRating.RockStar;
                        }

                        foreach (var member in allTeamMembers)
                        {
                            //add rating to list
                        }
                        Console.WriteLine("DRIVE has been updated");

                        if ( userUpdateMemeber.StartsWith('d'))
                        {
                            Console.WriteLine("You do not have permission to update this member.");
                            Console.WriteLine("Would you like to return to the Leader Main Menu? Enter [1] for yes or [2] to return to the main menu: ");
                            int answer2 = int.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    //loop back to main leader menu
                                    break;
                                case 2:
                                    Main();

                                    break;
                                default:
                                    Console.WriteLine("That was an invalid response");
                                    break;

                            }
                            



                            
                           
                            break;
                        }

                        break;
                }






            }
        }

        //Repository of Team Members
        public static class TeamMemberRepo
        {
            public static List<TeamMember> GetTeamMembers()
            {
                List<TeamMember> teamMembers = new List<TeamMember>
            {
                new TeamMember("Joe", "Spacito", "t1234", DriveRating.AchievingExpectations),
                new TeamMember("Jane", "Carrie", "t1235", DriveRating.AchievingExpectations),
                new TeamMember("Praj", "Nahim", "t1236", DriveRating.AchievingExpectations),
                new Leader("Fitz", "Caldwell", "l2239", DriveRating.AchievingExpectations),
                new Leader("Leslie", "Wrightfield", "l3239", DriveRating.AchievingExpectations),
                new Director("Charlie", "Georgina", "d5538", DriveRating.AchievingExpectations),
            };

                return teamMembers;
            }
        }

        //Team Member class
        public class TeamMember
        {
            //This is an auto-implemented property for the DriveRating Enum
            public DriveRating DriveRating { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CommonId { get; set; }

            public TeamMember(string firstname, string lastname, string commonid, DriveRating rating)
            {
                FirstName = firstname;
                LastName = lastname;
                CommonId = commonid;
                DriveRating = rating;

            }

            public virtual double DetermineBonus(DriveRating rating)
            {
                double bonus = 0;
                switch (rating)
                {
                    case DriveRating.NeedsImprovement:
                        bonus = 0.00;
                        break;
                    case DriveRating.AchievingExpectations:
                        bonus = 1000.00;
                        break;
                    case DriveRating.ExceedExpectations:
                        bonus = 5000.00;
                        break;
                    case DriveRating.RockStar:
                        bonus = 10000.00;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

                return bonus;

            }

        }

        public class Leader : TeamMember
        {
            public Leader(string firstname, string lastname, string commonid, DriveRating rating) : base(firstname, lastname, commonid, rating)
            {

            }

            public virtual double DetermineBonus(DriveRating rating)
            {
                double bonus = 0;
                switch (rating)
                {
                    case DriveRating.NeedsImprovement:
                        bonus = 0.00;
                        break;
                    case DriveRating.AchievingExpectations:
                        bonus = 2000.00;
                        break;
                    case DriveRating.ExceedExpectations:
                        bonus = 10000.00;
                        break;
                    case DriveRating.RockStar:
                        bonus = 20000.00;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

                return bonus;

            }
        }

        public class Director : TeamMember
        {
            public Director(string firstname, string lastname, string commonid, DriveRating rating) : base(firstname, lastname, commonid, rating)
            {

            }

            public virtual double DetermineBonus(DriveRating rating)
            {
                double bonus = 0;
                switch (rating)
                {
                    case DriveRating.NeedsImprovement:
                        bonus = 0.00;
                        break;
                    case DriveRating.AchievingExpectations:
                        bonus = 3000.00;
                        break;
                    case DriveRating.ExceedExpectations:
                        bonus = 15000.00;
                        break;
                    case DriveRating.RockStar:
                        bonus = 30000.00;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

                return bonus;

            }


            public void DetermineDirectorDrive(List<TeamMember> teamMembers)
            {
                for (int i = 0; i < teamMembers.Count; i++)
                {

                    while (DriveRating == DriveRating.ExceedExpectations)
                    {
                        DriveRating = DriveRating.RockStar;
                    }
                    while (DriveRating == DriveRating.ExceedExpectations && DriveRating != DriveRating.NeedsImprovement)
                    {
                        DriveRating = DriveRating.ExceedExpectations;
                    }
                    while (DriveRating == DriveRating.NeedsImprovement)
                    {
                        DriveRating = DriveRating.AchievingExpectations;
                    }
                    while (DriveRating == DriveRating.NeedsImprovement)
                    {
                        DriveRating = DriveRating.NeedsImprovement;
                    }

                }

            }
        }

        //This is the DriveRating Enum
        public enum DriveRating
        {
            NeedsImprovement,
            AchievingExpectations,
            ExceedExpectations,
            RockStar
        }
    }
}
