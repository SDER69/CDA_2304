package crm.sd.package_personnes;

import java.util.ArrayList;

import crm.sd.package_personnes.Personne;

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


