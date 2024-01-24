<?php
include '../pdo2.php';


function getAllAgences() {
    
    $pdo = PDO2::getInstance();
    
    $requete = $pdo->prepare("SELECT * FROM  WHERE Agence");
    $bv1 = $requete->bindValue(1,$id,PDO::PARAM_STR);
    $executionok = $requete->execute();
    $tab = $requete->fetchObject();
   if (is_array($tab)){
        return $tab;
   }
}

function getAgenceByName($name) {

   $pdo = PDO2::getInstance();
   $requete = $pdo->prepare("SELECT * FROM Agence WHERE Nom = ?");
   $bv1 = $requete->bindValue(1,$name,PDO::PARAM_STR);
   $executionok = $requete->execute();
   $tab = $requete->fetchObject();
   if (is_array($tab)){
        return $tab;
   }

}

function PostAgence($agence){

    $pdo = PDO2::getInstance();

    $agenceName = $agence ->getName();
    $agenceAddress = $agence -> getNumTel();
    $agenceMail = $agence -> getMail();


    $pdo = PDO2::getInstance();
    
    $requete = $pdo->prepare("INSERT INTO `Agence`(`Nom`, `NumTel`, `Mail`) VALUES (?,?,?)");
    $bv1 = $requete->bindValue(1,$agenceName,PDO::PARAM_STR);
    $bv1 = $requete->bindValue(2,$agenceAddress,PDO::PARAM_STR);
    $bv1 = $requete->bindValue(3,$agenceMail,PDO::PARAM_STR);
    $executionok = $requete->execute();
    return $executionok;

}

function PostClient($client){
    $pdo = PDO2::getInstance();

    $clientRaisonSocial = $client -> getRaisonSocial();
    $clientNumeroSiren = $client -> getNumeroSiren();
    $clientCodeApe = $client -> getCodeApe();
    $clientAdressePostal = $client -> getAdressePostal();
    
}

?>




?>
