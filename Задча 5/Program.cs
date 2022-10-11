Random rnd = new Random ();
int[] r2d = new int[4];
for (int i = 0; i < r2d.Length; i++) {
    r2d[i] = rnd.Next (-10, 10);
}
double A = Math.Pow((r2d[2]-r2d[0]), 2); 
double B = Math.Pow((r2d[3]-r2d[1]), 2);
double AB = Math.Sqrt((A+B));
Console.WriteLine("Расстояние между точками в пространстве 2D "+AB);

int[] r3d = new int[6];
for (int i = 0; i < r3d.Length; i++) {
    r3d[i] = rnd.Next (-10, 10);
}
double AC = Math.Pow((r3d[3]-r3d[0]), 2); 
double BC = Math.Pow((r3d[4]-r3d[1]), 2);
double CC = Math.Pow((r3d[5]-r3d[2]), 2);
double ABC = Math.Sqrt((AC+BC+CC));
Console.WriteLine("Расстояние между точками в пространстве 3D "+ABC);