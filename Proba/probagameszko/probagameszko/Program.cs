using System;

class Cube
{
    public int position; // A kocka pozíciója (1-től 9-ig)

    public Cube()
    {
        position = 6; // Kezdeti pozíció
    }

    public void Move(char key)
    {

        switch (key)
        {
            case 'w':
                position -= 4;
                break;
            case 's':
                position += 4;
                break;
            case 'd':
                position++;
                break;
            case 'a':
                position--;
                break;
            default:
                throw new ArgumentException("Használd a rendes billentyűket!: " + key);
        }

        if (position < 1 || position > 16)
        {
            position = 2;
            throw new ArgumentException("Kimentél a pályáról!");


        }
    }

    public void PrintMatrix()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                int cellPosition = (i - 1) * 4 + j;
                if (cellPosition == position)
                {
                    Console.Write("[X]");
                }
                else
                {
                    Console.Write("[ ]");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cube cube = new Cube();

        while (true)
        {

            Console.Write(" Nyomj meg egy billentyűt (w, s, d, a): ");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();
            try
            {
                cube.Move(key);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            cube.PrintMatrix();

        }
    }
}
