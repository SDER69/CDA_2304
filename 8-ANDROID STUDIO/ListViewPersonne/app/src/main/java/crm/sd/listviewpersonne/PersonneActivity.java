package crm.sd.listviewpersonne;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;


public class PersonneActivity extends Activity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_personne);

    }

    public void validate(View v) {
        this.getIntent().putExtra("nom","thiry");
        this.getIntent().putExtra("prenom","sophie");
        this.getIntent().putExtra("age",25);
        setResult(RESULT_OK,this.getIntent());
        this.finish();
    }

}