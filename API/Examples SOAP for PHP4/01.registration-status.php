<?
require_once("class.voipms.php");
$voipms = new VoIPms();

/* Account */
$account = "100000_VoIP";

/* Get Registration Status */
$response = $voipms->getRegistrationStatus($account);

/* Get Errors - Invalid_Account */
if($response[status]!='success'){
    echo $response[status];
    exit;
}

/* Is Registered */
echo "{$account} Registered : {$response[registered]}";

/* Get Registrations Array */
$registrations = $response[registrations];

/* Display Clients */
foreach($registrations as $registration){
    ?>
    <table style="border: 1px solid #336699; width:500px">
        <tr>
            <td>Server Name:</td>
            <td>
                <? echo $registration[server_name] ?>
            </td>
        <tr>
        
        <tr>
            <td>Server Short Name:</td>
            <td>
                <? echo $registration[server_shortname] ?>
            </td>
        <tr>
        
        <tr>
            <td>Server Hostame:</td>
            <td>
                <? echo $registration[server_hostname] ?>
            </td>
        <tr>
        
        <tr>
            <td>Server IP:</td>
            <td>
                <? echo $registration[server_ip] ?>
            </td>
        <tr>
        
        <tr>
            <td>Server Country:</td>
            <td>
                <? echo $registration[server_country] ?>
            </td>
        <tr>
        
        <tr>
            <td>Server POP:</td>
            <td>
                <? echo $registration[server_pop] ?>
            </td>
        <tr>
        
        <tr>
            <td>Register IP:</td>
            <td>
                <? echo $registration[register_ip] ?>
            </td>
        <tr>
        
        <tr>
            <td>Register Port:</td>
            <td>
                <? echo $registration[register_port] ?>
            </td>
        <tr>
        
        <tr>
            <td>Next Registration:</td>
            <td>
                <? echo $registration[register_next] ?>
            </td>
        <tr>
       
    </table>
    <br><br><br>
    <?
}



?>