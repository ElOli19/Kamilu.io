<?php
//llamo a los caompos 
$nombre = $_POST ['nombre'];
$correo = $_POST ['correo'];
$telefono = $_POST ['telefono'];
$mensaje = $_POST ['mensaje'];

// datos para el correo

$destinatario = "feroliv19@yahoo.com";
$asunto ="Prueba desde la web";


$carta = "De: $nombre \n";
$carta .= "Correo: $correo";
$carta .= "telefono: $telefono"; 
$carta .= "Mensaje: $mensaje";

// enviando la bomba 
mail ($destinatario, $asunto, $carta);
header('Location:envioMensaje.html')
?>