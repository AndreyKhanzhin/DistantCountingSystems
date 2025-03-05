Console.WriteLine("Сначало введите число, затем его систему счисления от 2 до 9. Программа преобразует число в десятичную СС.");
string x = Console.ReadLine();
string q1 = Console.ReadLine();
int result = 0;
int[] Array = [2, 3, 4, 5, 6, 7, 8, 9];
if ((int.TryParse(x, out int x1) == false) || (int.TryParse(q1, out int q2) == false) || (Array.Contains(q2) == false)){
    Console.WriteLine("Error");
}
else{
    int[] x1arr = x1.ToString().Reverse().Select(c => int.Parse(c.ToString())).ToArray();
    for (int i = 0; i < x1arr.Length; i++){
        if (x1arr[i] > q2)
        {
            Console.WriteLine("Число не принадлежит этой системе счисления.");
            break;
        }
        else
        {
            result += (int)(x1arr[i] * Math.Pow(q2, i));
        }
    }
    Console.WriteLine(result);
}