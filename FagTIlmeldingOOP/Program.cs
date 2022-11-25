using FagTIlmeldingOOP;
using System.Diagnostics.Contracts;
using System.Security;

Teacher niels = new("Prog", "Niels", "Olesen", new DateTime(1971, 2, 23));


Course client = new(FagEnum.ClientsideProgrammering, niels);
Course studi = new(FagEnum.Studieteknik, niels);
Course grundl = new(FagEnum.Grundlæggendeprogrammering, niels);
Course oop = new(FagEnum.OOP, niels);
Course datab = new(FagEnum.Databaseprogrammering, niels);
Course comptek = new(FagEnum.Computerteknologi, niels);
Course netværk = new(FagEnum.Netværk, niels);

int elevid = -1;
string? fNavn = null;
string? lNavn = null;
DateTime føzDag = DateTime.MinValue;
string? fagValg = null;
bool loopClose = false;
bool loopClose1 = false;
Enrollment enrollments = new();
do
{
    loopClose1 = false;
    do
    {
        try
        {
            Console.WriteLine("Indtast eleverid");
            elevid = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Indstasst firstenamer");
            fNavn = Console.ReadLine();

            Console.WriteLine("Indtast lastnamer");
            lNavn = Console.ReadLine();

            Console.WriteLine("Indtast føzdato");
            føzDag = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Vælg mellem disse fag:");
            Console.WriteLine(FagEnum.ClientsideProgrammering);
            Console.WriteLine(FagEnum.Studieteknik);
            Console.WriteLine(FagEnum.Grundlæggendeprogrammering);
            Console.WriteLine(FagEnum.OOP);
            Console.WriteLine(FagEnum.Computerteknologi);
            Console.WriteLine(FagEnum.Netværk);
            fagValg = Console.ReadLine();
            if (fagValg != Convert.ToString(FagEnum.ClientsideProgrammering) && fagValg != Convert.ToString(FagEnum.Studieteknik) && fagValg != Convert.ToString(FagEnum.Grundlæggendeprogrammering) && fagValg != Convert.ToString(FagEnum.OOP) && fagValg != Convert.ToString(FagEnum.Computerteknologi) && fagValg != Convert.ToString(FagEnum.Netværk)) 
            {
                throw new("Fag passer ikke");
            }
            loopClose1 = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (!loopClose1);

    if (fagValg == Convert.ToString(FagEnum.ClientsideProgrammering))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), client));
    }
    else if (fagValg == Convert.ToString(FagEnum.Studieteknik))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), studi));
    }
    else if (fagValg == Convert.ToString(FagEnum.Grundlæggendeprogrammering))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), grundl));
    }
    else if (fagValg == Convert.ToString(FagEnum.OOP))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), oop));
    }
    else if (fagValg == Convert.ToString(FagEnum.Databaseprogrammering))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), datab));
    }
    else if (fagValg == Convert.ToString(FagEnum.Computerteknologi))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), comptek));
    }
    else if (fagValg == Convert.ToString(FagEnum.Netværk))
    {
        enrollments.enrollment1.Add(new Enrollment(new Student(elevid, fNavn, lNavn, føzDag), netværk));
    }

    foreach (var item in enrollments.enrollment1)
    {
        Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}, fag: " +
        $"{item.CourseInfo.CourseName}, lærer: {item.CourseInfo.TeacherInfo.FirstName} " +
        $"{item.CourseInfo.TeacherInfo.LastName}");
    }
    Console.WriteLine("Vil du køre programmet igen?\nJa/Nej");
    string lukValg = Console.ReadLine().ToLower();
    if (lukValg == "nej")
    {
        loopClose = true;
    }
    
} while (!loopClose);

//Student jakob = new(7, "Jakob", "Hugo Rasmussen", new DateTime(2005, 9, 7));
//Student micki = new(9, "Micki", "Marinic Kok Olsen", new DateTime(2005, 12, 4));
//Student rasmus = new(2, "Rasmus", "Wiell", new DateTime(2004, 3, 18));

//Student ozan = new(5, "Ozan", "Korkmaz", new DateTime(1998, 4, 13));
//Student camilla = new(1, "Camilla", "Kløjgaard", new DateTime(1997, 2, 10));



//Enrollment enrollments = new();

//enrollments.enrollment1 = new List<Enrollment>()
//{
//new Enrollment(jakob, studi),
//new Enrollment(jakob, grundl),
//new Enrollment(jakob, oop),

//new Enrollment(micki, studi),
//new Enrollment(micki, grundl),
//new Enrollment(micki, oop),

//new Enrollment(rasmus, studi),
//new Enrollment(rasmus, grundl),
//new Enrollment(rasmus, oop),

//new Enrollment(ozan, grundl),
//new Enrollment(ozan, oop),

//new Enrollment(camilla, grundl),
//new Enrollment(camilla, oop)
//};
//int studiCount = 0;
//int grundlCount = 0;
//int oopCount = 0;
//foreach (var item in enrollments.enrollment1)
//{
//    if (item.CourseInfo.CourseName == FagEnum.Studieteknik)
//    {
//        studiCount++;
//    }
//    if (item.CourseInfo.CourseName == FagEnum.Grundlæggendeprogrammering)
//    {
//        grundlCount++;
//    }
//    if (item.CourseInfo.CourseName == FagEnum.OOP)
//    {
//        oopCount++;
//    }
//}
//try
//{
//    if (studiCount > 8 || studiCount < 16)
//    {
//        throw new Exception("Antallet af elever i Studietekeniker er ikke godkendt");
//    }
//    if (grundlCount > 8 || grundlCount < 16)
//    {
//        throw new Exception("Antallet af elever i Grundlæggende Programmering er ikke godkendt");
//    }
//    if (oopCount >8 || oopCount < 16)
//    {
//        throw new Exception("Antallet af elever i OOP er ikke godkendt");
//    }
//}
//catch (Exception parametre)
//{
//    Console.WriteLine(parametre.Message);
//}
////int count = enrollments.enrollment1.Contains(studi.CourseName(studi));
////int count= 0;
////count = enrollments.enrollment1.Distinct(enrollments).;
////Console.WriteLine(count);

//List<string> enrollments2 = jakob.GetAllCourses(enrollments);
//List<string> enrollments3 = jakob.GetAllCourses(enrollments.enrollment1);

//foreach (var item in enrollments2)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("\n\n");
//Console.WriteLine(niels.Day());
//Console.WriteLine(jakob.Day());
//enrollments.enrollment1.Sort();
//foreach (var item in enrollments.enrollment1)
//{
//    Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}, fag: " +
//        $"{item.CourseInfo.CourseName}, lærer: {item.CourseInfo.TeacherInfo.FirstName} " +
//        $"{item.CourseInfo.TeacherInfo.LastName}");
//}


//Console.WriteLine(micki.AgeCall());
//Console.WriteLine(niels.DepCall());

////throw new Exception()
////{

////};