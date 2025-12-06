// Pines del sensor ultrasonico
const int trigPin = 2;
const int echoPin = 4;

// Pines de los LEDs
const int led1 = 7;
const int led2 = 8;
const int led3 = 9;
const int led4 = 10;

// Buzzer
const int buzzer = 12;

long duracion;
int distancia;

void setup() {
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);

  pinMode(buzzer, OUTPUT);
  
  Serial.begin(9600);
}

void loop() {

  // ------ CALCULAR DISTANCIA ------
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  duracion = pulseIn(echoPin, HIGH);
  distancia = duracion * 0.034 / 2;

  // ----- ENVIAR DISTANCIA A VISUAL -----
  Serial.print("DIST:");
  Serial.println(distancia);

  // Apagar todo
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  digitalWrite(led4, LOW);
  noTone(buzzer);

  // ------ ENCENDIDOS SEGÚN DISTANCIA ------
  if (distancia > 40) {
    // Nada
  }
  else if (distancia > 30) {
    digitalWrite(led1, HIGH);
  }
  else if (distancia > 20) {
    digitalWrite(led2, HIGH);
  }
  else if (distancia > 10) {
    digitalWrite(led3, HIGH);
  }
  else {
    digitalWrite(led4, HIGH);
    tone(buzzer, 1000);
    delay(120);
    noTone(buzzer);
    delay(120);
  }

  delay(100);
}
