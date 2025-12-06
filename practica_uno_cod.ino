#include "DHT.h"

#define DHTPIN 6        // Pin donde está conectado el DHT11
#define DHTTYPE DHT11   // Tipo de sensor

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  delay(2000); // Espera 2 segundos entre lecturas

  float h = dht.readHumidity();      // Lee humedad
  float t = dht.readTemperature();   // Lee temperatura (°C)

  // Verifica si hubo error en la lectura
  if (isnan(h) || isnan(t)) {
    Serial.println("Error al leer el sensor DHT11");
    return;
  }

  Serial.print("Humedad: ");
  Serial.print(h);
  Serial.print("%   ");

  Serial.print("Temperatura: ");
  Serial.print(t);
  Serial.println("°C");
}