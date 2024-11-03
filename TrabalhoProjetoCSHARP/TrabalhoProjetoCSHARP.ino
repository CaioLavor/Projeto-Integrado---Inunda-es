#include <HCSR04.h>

const byte triggerPin = 12;
const byte echoPin = 13;
UltraSonicDistanceSensor distanceSensor(triggerPin, echoPin);

void setup () {
    Serial.begin(9600);
    pinMode(11, OUTPUT);
    digitalWrite(11, HIGH);  // We initialize serial connection so that we could print values from sensor.
}

void loop () {
    // Every 500 miliseconds, do a measurement using the sensor and print the distance in centimeters.
    int d1 = 0;
    int d2 = 0;
    int d3 = 0;
    int d4 = 20;

    d1 = distanceSensor.measureDistanceCm();
    d1 = d4 - d1;
    Serial.print(d1);
    delay(3000);
    /*d2 = distanceSensor.measureDistanceCm();
    d2 = d4 - d2;
    Serial.write(d2);

    if(d1 - d2 >= 3){
      d3 = d1 - d2;
      Serial.print("A água subiu ");
      Serial.print(d3);
      Serial.println("cm");
      Serial.println("Fique atento a possíveis inundações.");
      delay(5000);
    }*/
}

