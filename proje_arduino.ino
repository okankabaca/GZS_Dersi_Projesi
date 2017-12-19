#include <LiquidCrystal.h>

int Led = 47;
char okunan;
int nabizpin = A15;
double hesaplanan;
int trigPin = 49 ;
int echoPin = 48 ;
long sure;
long uzaklik;
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);
void setup ()
{ 
  lcd.begin(16, 2);            
  Serial.begin (9600);
  pinMode(Led,OUTPUT);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin,INPUT);
}
void loop ()
{
  
     static double eskideger = 0;
     int olculen = analogRead (nabizpin);
     hesaplanan = 0.75 * eskideger + 0.25 * olculen;
     eskideger = hesaplanan;
     delay(100);
        
   lcd.setCursor(0, 0);
   lcd.print("NABIZ:");
   lcd.print(hesaplanan/10);

    digitalWrite(trigPin, LOW);
    delayMicroseconds(5);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);  
    sure = pulseIn(echoPin, HIGH); 
    uzaklik = sure /29.1/2; // uzaklık formulü 
  
   lcd.setCursor(0, 1);
   lcd.print("UZUNLUK:");
   lcd.print(uzaklik);

if(Serial.available())
{
  okunan=Serial.read();
   switch (okunan){
    case 49: // Nabız
     Serial.println (hesaplanan/10);   // Nabız kodu sonu
     //Serial.println("1 calisti");
     break;      
    case 50: // Boy
    Serial.println(uzaklik); //cm olarak yazar
    //Serial.println("2 calisti");
    break; /// case 1 sonu
 }
}

}
