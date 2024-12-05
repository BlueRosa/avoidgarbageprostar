using System;
using System.Collections.Generic;

namespace AvoidGarbageProStar
{
    class Garbage
    {
        public string n;
        public List<Deplacement> d;

        public Garbage(string nom)
        {
            n = nom;
            d = new List<Deplacement>();
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

    class GarbageMove
    {
        static void Main()
        {
            var g = new Garbage("Garbage1");
            g.ajouter(DateTime.Now, 0, 0, 0);
            g.ajouter(DateTime.Now.AddSeconds(1), 1, 1, 45);
            g.ajouter(DateTime.Now.AddSeconds(2), 2, 2, 90);

            for (int i = 0; i < 1; i++)
            {
                g.afficher();
            }
        }
    }
}
