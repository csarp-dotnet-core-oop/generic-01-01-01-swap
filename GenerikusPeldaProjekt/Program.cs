using GenerikusPeldaProjekt;

string jegy1 = "5";
string jegy2 = "4";


Console.WriteLine(Cserelo<string>.ToString(jegy1,jegy2));
Cserelo<string>.Csere(ref jegy1, ref jegy2);
Console.WriteLine(Cserelo<string>.ToString(jegy1, jegy2));

Student lukrecia = new Student
{
    Name = "Lukrécia",
    Age = 16
};

Student szerenke = new Student
{
    Name = "Szerénke",
    Age = 17
};

Console.WriteLine(Cserelo<Student>.ToString(lukrecia,szerenke));
Cserelo<Student>.Csere(ref lukrecia,ref szerenke);
Console.WriteLine(Cserelo<Student>.ToString(lukrecia, szerenke));