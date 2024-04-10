package crm.sd.package_personnes;

import android.graphics.Bitmap;
import android.graphics.drawable.Drawable;

public class Personne {
    // Attributs
    private String nom;
    private String prenom;
    private Bitmap photo;
    // Contructeurs
    public Personne() {};
    public Personne(String _nom,String _prenom,Bitmap _photo)
    {
        this.nom = _nom;
        this.prenom = _prenom;
        this.photo = _photo;
    }

    // Getters et setters
    public String getNom()
    {
        return this.nom;
    }

    public String getPrenom()
    {
        return this.prenom;
    }

    public Bitmap getPhoto(){ return this.photo; }

    public void setNom(String nom)
    {
        this.nom = nom;
    }

    public void setPrenom(String prenom)
    {
        this.prenom = prenom;
    }

    public void setPhoto(Bitmap photo){ this.photo = photo; }


}
