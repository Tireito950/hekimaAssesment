class HekimaPrimarySchool
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hekima Primary School Grade Processing System");

        // Take marks of one pupil first
        for (int pupil = 1; pupil <= 30; pupil++) // Process 30 pupils
        {
            Console.WriteLine("\nProcessing grades for Pupil" + pupil);
            Console.Write("Enter the name of the pupil: ");
            string pupilName = Console.ReadLine();

            // enter the subjects to pupils do
            string[] subjects = { "Mathematical Activities", "Language", "Kiswahili", "Environmental Activities", "Creative Activities" };

            foreach (string subject in subjects) // Process one subject at a time
            {
                Console.WriteLine("\nSubject:" + subject);

                // tak scores for each exam
                Console.Write("Enter Opener score (0-100): ");
                int opener = int.Parse(Console.ReadLine());

                Console.Write("Enter Midterm score (0-100): ");
                int midterm = int.Parse(Console.ReadLine());

                Console.Write("Enter End Term score (0-100): ");
                int endTerm = int.Parse(Console.ReadLine());

                // Calculate average score
                double average = (opener + midterm + endTerm) / 3.0;

                // Show grading system
                string grade;
                if (average < 40)
                    grade = "Below Expectation";
                else if (average < 50)
                    grade = "Approaches Expectation";
                else if (average < 70)
                    grade = "Meets Expectation";
                else
                    grade = "Exceeds Expectation";

                // Show the result for this subject
                Console.WriteLine($"Average: {average:F2}, Grade: {grade}");
            }
        }

        Console.WriteLine("\nGrade processing complete. Thank you!");
    }
}



