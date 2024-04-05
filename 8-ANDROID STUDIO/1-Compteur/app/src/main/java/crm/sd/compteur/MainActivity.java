package crm.sd.compteur;


import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends Activity {

    private EditText result;
    private Button dec;
    private Button inc;

    // 2ème mèthode --> Ne pas oublier d'abonner le bouton dans le designer
    /*public void OnClickDec(View v) {
        DecClick();
    }*/

    public void OnClickQuit(View v){
        QuitClick();
    }

    // 1ère méthode
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        result = (EditText) findViewById(R.id.result);
        dec = (Button) findViewById(R.id.dec);
        inc = (Button) findViewById(R.id.inc);


        dec.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v){
                DecClick();
            }
        });

        inc.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v){
                IncClick();
        }
        });
    }
    // Méthodes
    private void DecClick()
    {
        String valueStr = result.getText().toString();
        int value = (int)Integer.parseInt(valueStr);
        value--;
        result.setText(String.valueOf(value));
    }

    private void IncClick()
    {
        String valueStr = result.getText().toString();
        int value = (int)Integer.parseInt(valueStr);
        value++;
        result.setText(String.valueOf(value));
    }

    private void QuitClick()
    {
        finish();
    }

}