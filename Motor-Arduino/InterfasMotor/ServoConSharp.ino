int aceleracion=0;
int valPwmMotor=0;
float ValVoltajeMotor=0;
int entradamotor=3;
int in1=6;
int in2=8;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  digitalWrite(in1,HIGH);
  digitalWrite(in2,LOW);
  analogWrite(entradamotor,0);
}

void loop() {
  // put your main code here, to run repeatedly:
  switch (Serial.read()) {
  case 'a':
    if(aceleracion<1015){
      aceleracion+=10;
      valPwmMotor=map(aceleracion,0,1023,0,255);
      analogWrite(entradamotor,valPwmMotor);
      ValVoltajeMotor=(5*(float)valPwmMotor)/255;
      Serial.println(ValVoltajeMotor);
    }
    break;
  case 'n':
    // statements
    digitalWrite(in1,LOW);
    digitalWrite(in2,HIGH);
    break;
  case 'h':
    // statements
    digitalWrite(in1,HIGH);
    digitalWrite(in2,LOW);
    break;
  case 'd':
    // statements
    if(aceleracion>10){
      aceleracion-=10;
      valPwmMotor=map(aceleracion,0,1023,0,255);
      analogWrite(entradamotor,valPwmMotor);
      ValVoltajeMotor=(5*(float)valPwmMotor)/255;
      Serial.println(ValVoltajeMotor);
    }
    break;
    case 'c':
    //statements
    aceleracion=0;
    valPwmMotor=map(aceleracion,0,1023,0,255);
    analogWrite(entradamotor,valPwmMotor);
    ValVoltajeMotor=(5*(float)valPwmMotor)/255;
    Serial.println(ValVoltajeMotor);
  default:
    break;
}

delay(25);
}
