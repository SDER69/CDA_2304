package crm.sd.listview;

import android.content.Context;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import java.util.List;

import crm.sd.package_personnes.ListeDePersonnes;
import crm.sd.package_personnes.Personne;

public class PersonneArrayAdapter extends ArrayAdapter<Personne> {

    // Attribut
    private ListeDePersonnes listeDePersonnes;

    // Constructeur
    public PersonneArrayAdapter(Context context, ListeDePersonnes personnes) {
        super(context, R.layout.model_item, (List<Personne>) personnes.getListPersonnes());
        listeDePersonnes = personnes;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        //return super.getView(position, convertView, parent);

        View v = convertView;
        if (v == null) {
            LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v = inflater.inflate(R.layout.model_item, null);
        }
        Personne personneOfItem = (Personne) listeDePersonnes.getListPersonnes().get(position);
        if (personneOfItem != null) {
            TextView nomView = (TextView) v.findViewById(R.id.textViewNom);
            TextView prenomView = (TextView) v.findViewById(R.id.textViewPr);
            ImageView photoView = (ImageView) v.findViewById(R.id.imageViewPhoto);

            if (nomView != null) {
                nomView.setText("Name : " + personneOfItem.getNom());
            }
            if (prenomView != null) {
                prenomView.setText("Prenom : " + personneOfItem.getPrenom());
            }
            /*if (photoView != null) {
                if (personneOfItem.getPhoto() != null) {
                    photoView.setImageBitmap(personneOfItem.getPhoto());
                } else {
                    photoView.setImageDrawable(v.getResources().getDrawableForDensity(R.drawable.absent, DisplayMetrics.DENSITY_XHIGH));
                }
            }*/
        }

        return v;
    }
}



