﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMCP
{
    public class InterfaceOrienteObjet : IMode
    {
        /// <summary>
        /// Permet de dessiner un carré en prennant comme origine l'arrete supérieure gauche du carré.
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="taille"></param>
        public Rectangle DessinerCarre(Vector2 position, int taille)
        {
            Rectangle r = new Rectangle(position, taille, taille);
            Canvas.Formes.Add(r);
            Canvas.Graphic.DrawRectangle(new Pen(Color.Black), position.X, position.Y, taille, taille);
            Console.WriteLine("Un carré a été dessiné.");
            return r;
        }

        public Rectangle DessinerRectangle(Vector2 position, int largeur, int hauteur )
        {
            Rectangle r = new Rectangle(position, largeur, hauteur);
            Canvas.Formes.Add(r);
            Canvas.Graphic.DrawRectangle(new Pen(Color.Black), position.X, position.Y, largeur, hauteur);
            Console.WriteLine("Un rectangle a été dessiné.");
            return r;
        }

        public Cercle DessinerCercle(Vector2 position, int rayon)
        {
            Cercle c = new Cercle(position, rayon);
            Canvas.Formes.Add(c);
            Canvas.Graphic.DrawEllipse(new Pen(Color.Black), position.X, position.Y, rayon, rayon);
            Console.WriteLine("Un cercle a été dessiné.");
            return c;
        }

        public void DessinerTriangle(Vector2 position, int taille)
        {
            
        }

        public void DessinerLosange(Vector2 position, int largeur, int hauteur)
        {

        }

        public void DessinerEtoile(Vector2 position, int taille, int nbSommet)
        {

        }

        public void DessinerEllipse(Vector2 position, int rayon1, int rayon2)
        {

        }

    }
}
