package crm.sd.listview;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.media.Image;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import crm.sd.package_personnes.ListeDePersonnes;
import crm.sd.package_personnes.Personne;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ajouterMembre();

    }
    public void ajouterMembre()
    {
        String[] tab = new String[]{"membre1","membre2","membre3","membre4","membre5"};
        ArrayAdapter arrayAdp = new ArrayAdapter(this,android.R.layout.simple_list_item_1, tab);
        ListView list = findViewById(R.id.listView);
        list.setAdapter(arrayAdp);


        //ListeDePersonnes personnes = new ListeDePersonnes();
        //Bitmap b = ((BitmapDrawable) ContextCompat.getDrawable(R.drawable.lion)).getBitmap();
        //Bitmap b = BitmapFactory.decodeResource(getResources(), R.drawable.ic_launcher_background);

        //personnes.addPersonne(new Personne("Derbal","Said",b));
        //personnes.addPersonne(new Personne("Thiry","Sophie",b));
        /*PersonneArrayAdapter personneArrayAdapter = new PersonneArrayAdapter(this, personnes);
        ListView list = findViewById(R.id.listView);
        list.setAdapter(personneArrayAdapter);*/
    }



    {

    }
}