using System;
using System.Collections.Generic;
using System.Linq;


namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(':')
                .ToArray();

            while (!commands[0].Contains("course"))
            {
                if (commands[0] == "Add")
                {
                    string lessonTitle = commands[1];

                    courses = Add(lessonTitle, courses);
                }
                else if (commands[0] == "Insert")
                {
                    string lessonTitle = commands[1];
                    int indexToInsertAt = int.Parse(commands[2]);

                    courses = Insert(lessonTitle, indexToInsertAt, courses);
                }
                else if (commands[0] == "Remove")
                {
                    string lessonTitle = commands[1];

                    courses = Remove(lessonTitle, courses);
                }
                else if (commands[0] == "Swap")
                {
                    string firstLessonTitle = commands[1];
                    string secondLessonTitle = commands[2];

                    courses = Swap(firstLessonTitle, secondLessonTitle, courses);
                }
                else if (commands[0] == "Exercise")
                {
                    string exerciseTitle = commands[1];
                    courses = Exercise(exerciseTitle, courses);
                }

                commands = Console.ReadLine()
                .Split(':')
                .ToArray();
            }
            // print end List
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }

        static List<string> Add(string lessonTitle,
            List<string> listOfLessons)
        {
            bool lessonIsIncluded = false;

            foreach (string lesson in listOfLessons)
            {
                if (lessonTitle == lesson)
                {
                    lessonIsIncluded = true;
                    break;
                }
            }

            if (!lessonIsIncluded)
            {
                listOfLessons.Add(lessonTitle);
            }

            return listOfLessons;
        }

        static List<string> Insert(string lessonTitle,
            int indexToInsertAt,
            List<string> listOfLessons)
        {
            bool lessonIsIncluded = true;

            foreach (string lesson in listOfLessons)
            {
                if (lessonTitle == lesson)
                {
                    lessonIsIncluded = true;
                    break;
                }
                else
                {
                    lessonIsIncluded = false;
                }
            }

            if (!lessonIsIncluded)
            {
                listOfLessons.Insert(indexToInsertAt, lessonTitle);
            }

            return listOfLessons;
        }
        static List<string> Remove(string lessonTitle,
            List<string> listOfLessons)
        {
            bool lessonIsIncluded = false;

            foreach (string lesson in listOfLessons)
            {
                if (lessonTitle == lesson)
                {
                    lessonIsIncluded = true;
                    break;
                }
            }

            if (lessonIsIncluded)
            {
                listOfLessons.Remove(lessonTitle);
                listOfLessons.Remove(lessonTitle + "-Exercise"); //fulfilling the condition where we're required
            }

            return listOfLessons;
        }

        static List<string> Swap(string lessonTitle,
            string secondLessonTitle,
            List<string> listOfLessons)
        {

            bool lessonTitleExist = false;
            bool secondLessonTitleExist = false;

            int lessonTitleIndex = 0;
            int secondLessonTitleIndex = 0;


            //check if lessons exist
            for (int i = 0; i < listOfLessons.Count; i++)
            {
                if (listOfLessons[i] == lessonTitle)
                {
                    lessonTitleExist = true;
                    lessonTitleIndex = i;
                    continue;
                }
                if (listOfLessons[i] == secondLessonTitle)
                {
                    secondLessonTitleExist = true;
                    secondLessonTitleIndex = i;
                    break;
                }
            }

            if (lessonTitleExist && secondLessonTitleExist)
            {
                //swap lesson locations

                listOfLessons.RemoveAt(lessonTitleIndex);
                listOfLessons.Insert(lessonTitleIndex, secondLessonTitle);

                listOfLessons.RemoveAt(secondLessonTitleIndex);
                listOfLessons.Insert(secondLessonTitleIndex, lessonTitle);

                //swap exercise locations for the same lessons - if any exercises exist

                bool exerciseTitleExist = false;
                bool secondExerciseTitleExist = false;

                string firstExerciseName = lessonTitle + "-Exercise";
                string secondExerciseName = secondLessonTitle + "-Exercise";

                int exerciseTitleIndex = 0;
                int secondExerciseTitleIndex = 0;

                for (int i = 0; i < listOfLessons.Count; i++)
                {
                    if (listOfLessons[i] == firstExerciseName)
                    {
                        exerciseTitleIndex = i;
                        exerciseTitleExist = true;
                    }

                    if (listOfLessons[i] == secondExerciseName)
                    {
                        secondExerciseTitleIndex = i;
                        secondExerciseTitleExist = true;
                    }
                }

                if (exerciseTitleExist)
                {
                    listOfLessons.RemoveAt(lessonTitleIndex + 1);
                    listOfLessons.Insert(secondLessonTitleIndex + 1, firstExerciseName); //the index is such
                                                                                         //since we made a swap
                }
                if (secondExerciseTitleExist)
                {
                    listOfLessons.RemoveAt(secondLessonTitleIndex + 1);
                    listOfLessons.Insert(lessonTitleIndex + 1, secondExerciseName);
                }
            }

            return listOfLessons;
        }

        static List<string> Exercise(string exercise,
        List<string> listOfLessons)
        {
            bool lessonExists = false;
            int lessonIndex = 0;

            bool exerciseDoesNotExist = true;
            string exerciseName = exercise + "-Exercise";

            for (int i = 0; i < listOfLessons.Count; i++)
            {
                if (listOfLessons[i] == exercise)
                {
                    lessonExists = true;
                    lessonIndex = i;
                }

                if (listOfLessons[i] == exerciseName)
                {
                    exerciseDoesNotExist = false;
                }
            }

            if (lessonExists && exerciseDoesNotExist)
            {
                listOfLessons.Insert(lessonIndex + 1, exerciseName);
            }
            else if (!lessonExists && exerciseDoesNotExist) //mind "!"
            {
                listOfLessons.Add(exercise);
                listOfLessons.Add(exerciseName);
            }

            return listOfLessons;
        }
    }
}