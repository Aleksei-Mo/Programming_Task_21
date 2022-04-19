// Задача 21. Напишите программу, которая принимает на вход координаты 2х точек трехмерного пространства и находит расстояние между ними.
Console.WriteLine("This programm finds the distance between 2 dots in 3D space.");

double xA=EnterCoordinate("x","A");
double yA=EnterCoordinate("y","A");
double zA=EnterCoordinate("z","A");
double xB=EnterCoordinate("x","B");
double yB=EnterCoordinate("y","B");
double zB=EnterCoordinate("z","B");

double distance = Distance(xA,yA,zA,xB,yB,zB);//call function Distance
Console.WriteLine($"The distance between dot A({xA},{yA},{zA}) and dot B({xB},{yB},{zB}) is {distance}");



double EnterCoordinate (string coordName, string dotName)// this function implements frendly input
{
 Console.Write($"Enter coordinate {coordName} of the dot {dotName}: ");
 return Convert.ToDouble(Console.ReadLine());
}


double Distance (double xA, double yA,double zA, double xB, double yB,double zB)// this function calculates distance between points
{
 double coordX=Math.Pow((xB-xA),2);
 double coordY=Math.Pow((yB-yA),2);
 double coordZ=Math.Pow((zB-zA),2);
 double distance=Math.Pow((coordX+coordY+coordZ),0.5);
 return distance;
}