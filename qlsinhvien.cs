using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Ma { get; set; }
    public string Ten { get; set; }
    public int Tuoi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
        {
            new Student { Ma = 1, Ten = "An", Tuoi = 16 },
            new Student { Ma = 2, Ten = "Binh", Tuoi = 18 },
            new Student { Ma = 3, Ten = "Chi", Tuoi = 14 },
            new Student { Ma = 4, Ten = "Anh", Tuoi = 17 },
            new Student { Ma = 5, Ten = "Dang", Tuoi = 19 }
        };

        // a. In toàn bộ danh sách học sinh
        Console.WriteLine("Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Ma: {student.Ma}, Ten: {student.Ten}, Tuoi: {student.Tuoi}");
        }

        // b. Tìm các học sinh có tuổi từ 15 đến 18
        var ageRangeStudents = students.Where(s => s.Tuoi >= 15 && s.Tuoi <= 18).ToList();
        Console.WriteLine("\nHoc sinh tuoi tu 15 den 18:");
        foreach (var student in ageRangeStudents)
        {
            Console.WriteLine($"Ma: {student.Ma} ,Ten:  {student.Ten} , Tuoi:  {student.Tuoi}");
        }

        // c. Tìm học sinh có tên bắt đầu bằng chữ "A"
        var studentsWithA = students.Where(s => s.Ten.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
        foreach (var student in studentsWithA)
        {
            Console.WriteLine($"Ma: {student.Ma} ,Ten:  {student.Ten} , Tuoi:  {student.Tuoi}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        int totalAge = students.Sum(s => s.Tuoi);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tìm học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Tuoi).FirstOrDefault();
        Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
        Console.WriteLine($"Ma: {oldestStudent.Ma} , Ten:  {oldestStudent.Ten} , Tuoi:  {oldestStudent.Tuoi}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần
        var sortedStudents = students.OrderBy(s => s.Tuoi).ToList();
        Console.WriteLine("\nDanh sach sap xep theo tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Ma: {student.Ma}  , Ten:   {student.Ten}  , Tuoi:   {student.Tuoi}");
        }
    }
}
