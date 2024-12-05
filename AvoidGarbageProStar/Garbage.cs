using System;
using System.Collections.Generic;

namespace AvoidGarbageProStar
{
    class Garbage
    {
        public string n;
        public List<Deplacement> d;
        public Partern p;

        public Garbage(string nom, Partern partern)
        {
            n = nom;
            d = new List<Deplacement>();
            p = partern;
        }

        public void ajouter(DateTime dt, float x, float y, float r)
        {
            d.Add(new Deplacement(dt, x, y, r));
        }

        public void afficher()
        {
            Console.WriteLine($"Déplacements de l'objet {n}:");
            foreach (var dp in d)
            {
                afficherDeplacement(dp);
            }
        }

        private void afficherDeplacement(Deplacement dp)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Date: {dp.dt}, Position: ({dp.x}, {dp.y}), Rotation: {dp.r} degrés");
            }
        }

        public void suivreTrajectoire()
        {
            for (int i = 0; i < 10; i++)
            {
                float x = i;
                float y = p.a * x * x + p.b * x + p.c;
                ajouter(DateTime.Now.AddSeconds(i), x, y, 0);
            }
        }
    }

    class Deplacement
    {
        public DateTime dt;
        public float x, y, r;

        public Deplacement(DateTime date, float xx, float yy, float rr)
        {
            dt = date;
            x = xx;
            y = yy;
            r = rr;
        }
    }

    class Partern
    {
        public int a, b, c;

        public Partern(int aa, int bb, int cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }
    }

    class GarbageMove
    {
        static void Main()
        {
            var p = new Partern(1, 2, 3);
            var g = new Garbage("Garbage1", p);
            g.suivreTrajectoire();
            g.afficher();
        }
    }
}
