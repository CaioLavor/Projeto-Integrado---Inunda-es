#include <HCSR04.h>
byte i = 0;
const byte triggerPin = 12; //porta trigger do sensor
const byte echoPin = 13; //porta echo do sensor
UltraSonicDistanceSensor distanceSensor(triggerPin, echoPin); //identificando as portas na biblioteca

    int DistanciaDoSensor = 0; //distancia entre o sensor e a água
    int TamanhoDoRecipiente = 20; //tamanho do recipiente em cm

void setup () {
    Serial.begin(9600);
    pinMode(11, OUTPUT); //tornando a porta 11 do arduino em alimentação
    digitalWrite(11, HIGH); //ligando a porta 11 em 5v
}

void loop () {

if (Serial.available())
  {
    switch (Serial.read())
    {
      case 'A':
      //digitalWrite(LED, 1); //acende o led para indicar que o sensor está ligado
         while (true) {  // loop infinito que só será interrompido pela condição
            DistanciaDoSensor = distanceSensor.measureDistanceCm();
            DistanciaDoSensor = TamanhoDoRecipiente - DistanciaDoSensor;
            Serial.println(DistanciaDoSensor);
            //delay(3000); 

    // verifica se há dados disponíveis na Serial
            //if (Serial.available()){
            //int desliga = Serial.read();  // lê o valor enviado pela Serial

      // verifica se o comando é para sair do loop
            //if (desliga == 'B') { 
              //digitalWrite(11, LOW); //desliga o led para indicar que o sensor desligou
            //break;
      //}
    //}
  }
        break;

      case 'L':
        DistanciaDoSensor = distanceSensor.measureDistanceCm();
        DistanciaDoSensor = TamanhoDoRecipiente - DistanciaDoSensor;
        Serial.println(DistanciaDoSensor);
        break;
    }
  }
    DistanciaDoSensor = distanceSensor.measureDistanceCm();
    DistanciaDoSensor = TamanhoDoRecipiente - DistanciaDoSensor;
    Serial.println(DistanciaDoSensor);
    //delay(3000);
}

