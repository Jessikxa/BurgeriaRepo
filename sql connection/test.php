<?php


$servername = "mysql";
$username = "root";
$password = "password";
$database = "burgerGame";

//create connection

    $conn = new mysqli($servername,$username,$password,$database);
    if($conn->connect_error){
        error_log($conn->connect_error);
        exit("Connect with database failed");
    } 


$sql = "SELECT * FROM `burger` WHERE 1";

$result = $conn->query($sql);

if($result->num_rows >0){
    while($row = $result->fetch_assoc()){
        echo "id: " . $row['idburger'] . "userName" . $row['userName'] . "burgerName" . $row['burgerName'] . "ingredients" . $row['ingredients'] "<br>";
    }
}else{
    echo "no results";
}


$conn->close();

?>