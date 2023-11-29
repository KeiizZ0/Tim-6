using System;

class TebakKata
{
    static void Main()
    {
        bool mainLagi = false;
        do
        {
            string[] daftarKata = { "kucing", "komputer", "bola", "rumah", "sekolah" };
            Random random = new Random();
            string kataTebak = daftarKata[random.Next(0, daftarKata.Length)];
            char[] kataArray = kataTebak.ToCharArray();
            char[] tebakanArray = new char[kataTebak.Length];

            for (int i = 0; i < kataTebak.Length; i++)
            {
                if (i % 2 == 0) // Mengganti abjad dengan "*"
                {
                    tebakanArray[i] = '*';
                }
                else
                {
                    tebakanArray[i] = kataArray[i];
                }
            }

            bool tebakanBenar = false;

            Console.WriteLine("Selamat datang di permainan tebak kata!");
            do
            {
                Console.WriteLine("\nTebak kata: " + new string(tebakanArray));
                Console.Write("Masukkan tebakan huruf: ");
                char tebakanHuruf = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                for (int j = 0; j < kataTebak.Length; j++)
                {
                    if (tebakanHuruf == kataArray[j])
                    {
                        tebakanArray[j] = tebakanHuruf;
                    }
                }

                if (new string(tebakanArray) == kataTebak)
                {
                    tebakanBenar = true;
                    Console.WriteLine("\nSelamat! Kamu berhasil menebak kata: " + kataTebak);
                }

            } while (!tebakanBenar);

            Console.Write("\nIngin bermain lagi? (y/n): ");
            char jawaban = Char.ToLower(Console.ReadKey().KeyChar);
            if (jawaban == 'y')
            {
                mainLagi = true;
                Console.WriteLine("\n\n");
            }
            else
            {
                mainLagi = false;
            }

        } while (mainLagi);

        Console.WriteLine("\nTerima kasih telah bermain!");
    }
}
