package  crm.sd.listviewpersonne;

import static androidx.activity.result.ActivityResultCallerKt.registerForActivityResult;


import android.app.Activity;
import android.app.Instrumentation;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.result.ActivityResult;

import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AppCompatActivity;


public class MainActivity extends AppCompatActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        ajouterMembre();

    }



    public void ajouterMembre()
    {
        /*String[] tab = new String[]{"membre1","membre2","membre3","membre4","membre5"};
        ArrayAdapter arrayAdp = new ArrayAdapter(this,android.R.layout.simple_list_item_1, tab);
        ListView list = findViewById(R.id.listView);
        list.setAdapter(arrayAdp);*/


        ListeDePersonnes personnes = new ListeDePersonnes();

        Bitmap l = BitmapFactory.decodeResource(getResources(), R.drawable.lion);
        Bitmap w = BitmapFactory.decodeResource(getResources(), R.drawable.whale);

        personnes.addPersonne(new Personne("Derbal","Said",l));
        personnes.addPersonne(new Personne("Thiry","Sophie",w));
        PersonneArrayAdapter personneArrayAdapter = new PersonneArrayAdapter(this, personnes);
        ListView list = findViewById(R.id.listView);
        list.setAdapter(personneArrayAdapter);
    }



    public void onAjouterUnePersonne(View v){
            Intent intent = new Intent(this, PersonneActivity.class);
            //startActivity(intent);
            someActivityResultLauncher.launch(intent);
        }

// You can do the assignment inside onAttach or onCreate, i.e, before the activity is displayed
        ActivityResultLauncher<Intent> someActivityResultLauncher = registerForActivityResult(
                new ActivityResultContracts.StartActivityForResult(),
                new ActivityResultCallback<ActivityResult>() {
                    @Override
                    public void onActivityResult(ActivityResult result) {
                        if (result.getResultCode() == Activity.RESULT_OK) {
                            // There are no request codes
                            Intent data = result.getData();
                            String nom = result.getData().getStringExtra("nom");
                            doSomeOperations();
                        }
                    }
                });

    private void doSomeOperations() {
    }


}