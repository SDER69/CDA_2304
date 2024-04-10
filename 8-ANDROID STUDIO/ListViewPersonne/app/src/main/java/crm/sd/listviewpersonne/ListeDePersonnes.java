package crm.sd.listviewpersonne;

import android.graphics.Bitmap;

import java.util.ArrayList;

public class ListeDePersonnes {
    // Attributs
    private ArrayList<Personne> list;

    // Contructeurs
    public ListeDePersonnes()
    {
        list = new ArrayList();
    }

    public void addPersonne(Personne p)
    {
        list.add(p);
    }

    public ArrayList<Personne> getListPersonnes()
    {
        return this.list;
    }
}