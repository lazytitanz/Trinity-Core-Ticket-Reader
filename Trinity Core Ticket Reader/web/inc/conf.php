<?php

// Don't touch outside of testing environment

ini_set("display_errors", true); // Set true or false to display php errors on site. For debugging only.

// Site info, not used yet


// Database information

$host = "localhost"; // Hostname of mysqlserver
$dbase = ""; // Target database
$username = ""; // MySQL username
$password = ""; // MySQL password

// SOAP information (credit: dilios ac-web.org)

// hostname of your server 
if (!defined('SOAP_IP')) define('SOAP_IP', 'ip or hostname'); 
// Port for SOAP server 
if (!defined('SOAP_PORT')) define('SOAP_PORT', '7878'); 
// Account name to handle SOAP commands (needs RBAC permissions 219 and 228 for TrinityCore) 
if (!defined('SOAP_USER')) define('SOAP_USER', 'accountname'); 
// Account name password 
if (!defined('SOAP_PASS')) define('SOAP_PASS', 'somepassword'); 
// Define which SOAP URI gets used 
// This allows for easy switching between different emulators 
if (!defined('SOAP_URI')) define('SOAP_URI', 'urn:TC'); 
//if (!defined('SOAP_URI')) define('SOAP_URI', 'urn:MaNGOS');

class soap { 
    private $messages = array(); 
    private $soap; 
    public function __construct() { 
        try { 
            $this -> connect(); 
        } 
        catch (Exception $e) { 
            $this -> addMessage($e -> getMessage()); 
        } 
    } 
    public function connect() { 
        $this -> soap = new SoapClient(NULL, array( 
            'location'=> 'http://'. SOAP_IP .':'. SOAP_PORT .'/', 
            'uri' => SOAP_URI, 
            'style' => SOAP_RPC, 
            'login' => SOAP_USER, 
            'password' => SOAP_PASS, 
            'keep_alive' => false 
        )); 
    } 

    public function cmd($command) { 
        $result = $this -> soap -> executeCommand(new SoapParam($command, 'command')); 
        $this -> addMessage($result); 
        return true; 
    } 

    public function addMessage($message) { 
        $this -> messages[] = $message; 
        return true; 
    } 

    public function getMessages() { 
        return $this -> messages; 
    } 
?>