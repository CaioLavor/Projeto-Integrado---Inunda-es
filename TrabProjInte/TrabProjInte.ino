#include <HCSR04.h>

const byte triggerPin = 13;
const byte echoPin = 12;
UltraSonicDistanceSensor distanceSensor(triggerPin, echoPin);

void setup () {
    Serial.begin(9600);  // We initialize serial connection so that we could print values from sensor.
}

void loop () {
    // Every 500 miliseconds, do a measurement using the sensor and print the distance in centimeters.
    int d1 = 0;
    int d2 = 0;
    int d3 = 0;

    Serial.println("============================================");
    Serial.println("Ciclo de medição de água:");
    delay(500);

    d1 = distanceSensor.measureDistanceCm();
    Serial.print("Primeira medição do nível da água: ");
    Serial.print(d1);
    Serial.println("cm");
    
    delay(3000);

    d2 = distanceSensor.measureDistanceCm();
    Serial.print("Segunda medição do nível da água: ");
    Serial.print(d2);
    Serial.println("cm");

    if(d1 - d2 >= 3){
      d3 = d1 - d2;
      Serial.print("A água subiu ");
      Serial.print(d3);
      Serial.println("cm");
      Serial.println("Fique atento a possíveis inundações.");
      delay(5000);
    }

    Serial.println("============================================");
    
    delay(3000);

    
}
