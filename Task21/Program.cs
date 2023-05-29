// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)


int[] dotA = new int[3];
Console.WriteLine("Введите три координаты точки x");
for (int i = 0; i < dotA.Length; i++)
{
    dotA[i] = Convert.ToInt32(Console.ReadLine());
}

int[] dotB = new int[3];
Console.WriteLine("Введите три координаты точки y");
for (int i = 0; i < dotB.Length; i++)
{
    dotB[i] = Convert.ToInt32(Console.ReadLine());
}

double distance = Math.Sqrt((dotA[0]-dotB[0])*(dotA[0]-dotB[0])+(dotA[1]-dotB[1])*(dotA[1]-dotB[1])+(dotA[2]-dotB[2])*(dotA[2]-dotB[2]));
distance = Math.Round(distance, 2);

Console.WriteLine("Расстояние между точками X и Y: " + distance);





