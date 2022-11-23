using System.Security;

Teacher niels = new("Prog", "Niels", "Olesen", new DateTime(1971, 2, 23));

Student jakob = new(7, "Jakob", "Hugo Rasmussen", new DateTime(2005, 9, 7));
Student micki = new(9, "Micki", "Marinic Kok Olsen", new DateTime(2005, 12, 4));
Student rasmus = new(2, "Rasmus", "Wiell", new DateTime(2004, 3, 18));

Student ozan = new(5, "Ozan", "Korkmaz", new DateTime(1998, 4, 13));
Student camilla = new(1, "Camilla", "Kløjgaard", new DateTime(1997, 2, 10));

Course studi = new("Studieteknik", niels);
Course grundl = new("Grundlæggendeprogrammering", niels);
Course oop = new("OOP", niels);
//Person p = new();

Enrollment enrollments = new();

enrollments.enrollment1 = new List<Enrollment>()
{
new Enrollment(jakob, studi),
new Enrollment(jakob, grundl),
new Enrollment(jakob, oop),

new Enrollment(micki, studi),
new Enrollment(micki, grundl),
new Enrollment(micki, oop),

new Enrollment(rasmus, studi),
new Enrollment(rasmus, grundl),
new Enrollment(rasmus, oop),

new Enrollment(ozan, grundl),
new Enrollment(ozan, oop),

new Enrollment(camilla, grundl),
new Enrollment(camilla, oop)
};

List<string> enrollments2 = jakob.GetAllCourses(enrollments);
foreach (var item in enrollments2)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n\n");
Console.WriteLine(niels.Day());
Console.WriteLine(jakob.Day());
foreach (var item in enrollments.enrollment1)
{
    Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}, fag: " +
        $"{item.CourseInfo.CourseName}, lærer: {item.CourseInfo.TeacherInfo.FirstName} " +
        $"{item.CourseInfo.TeacherInfo.LastName}");
}


Console.WriteLine(micki.AgeCall());
Console.WriteLine(niels.DepCall());