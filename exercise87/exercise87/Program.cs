using exercise87.Models;

TemperatureSensor temperatureSensor = new TemperatureSensor();
PresenceSensor presenceSensor = new PresenceSensor();

temperatureSensor.Activate();
temperatureSensor.Disable();

presenceSensor.Activate();
presenceSensor.Disable();
