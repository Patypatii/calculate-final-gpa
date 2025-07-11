string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

Console.WriteLine($"Student Name:  {studentName}");
Console.WriteLine("Course\t\t\tGradeCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t8\t{course1Credit}");

Console.WriteLine($"{course2Name}\t\t\t5\t{course2Credit}");

Console.WriteLine($"{course3Name}\t\t\t7\t{course3Credit}");

Console.WriteLine($"{course4Name}\t\t\t9\t{course4Credit}");

Console.WriteLine($"{course5Name}\t\t\t1\t{course5Credit}");


Console.WriteLine($"Final GPA: {course1Credit + course2Credit + course3Credit + course4Credit + course5Credit} / 5");