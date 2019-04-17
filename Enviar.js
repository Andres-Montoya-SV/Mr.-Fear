//Para el ID y PASSWORD se necesita tener una cuenta en https://www.twilio.com/
//Programa hecho con NODE.js y la libreria TWILIO//

var twilio = require("twilio");

var cliente = new twilio.RestClient("ID", "PASSWORD");

cliente.sms.message.create({
	to: "Numero Para enviar",
	from: "Numero que envia", 
	body: "Hola usuario, ingresa al sitio web ---> 'SITIO' para probar el nuevo servicio"
}, function Prueba(error, message) {
	if (!error)
	{
		alert("Mensaje enviado");
	}
	else
	{
		alert("Mensaje ha fallado en el envio");
	}
});