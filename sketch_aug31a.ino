//Aqui se crean las variable
String data;
String d;
char dl;
int dint;
int i = 1;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);//Para inicializar el puerto serial
                     //C# usa los mismos parametros por defecto (8bit, no paridad, un bit de parada)
  pinMode(4, OUTPUT); //se selecciona el pin 4(D14) como salida (P0)
  pinMode(5, OUTPUT); //se selecciona el pin 5(D15) como salida (P1)
  pinMode(6, OUTPUT); //se selecciona el pin 6(D16) como salida (P2)
  pinMode(7, OUTPUT); //se selecciona el pin 7(D17) como salida (P3)
  pinMode(10, OUTPUT);//se selecciona el pin 10(D20) como salida (señal LOAD)

}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()) {         //si el puerto serial esta habilitado con datos
    data = Serial.readString();
    dl = data.charAt(0);

    if (dl == "I") {                //señal de encendido

      digitalWrite(4, LOW);        //pongo ceros en todos los pines P3-P0
      digitalWrite(5, LOW);
      digitalWrite(6, LOW);
      digitalWrite(7, LOW);

      while (i <= 4) {
        d = data.substring(i);     //bit mas significativo el que se envia al pin 7(D17) como salida (P3)
        dint = d.toInt();
        if (dint == 1) {
          dint = dint + 2 + i;
          digitalWrite(dint, HIGH);
        };
        i++;
      };
      digitalWrite(10, HIGH);      //señal de LOAD al contador
      i = 1;



    };
  };
}
