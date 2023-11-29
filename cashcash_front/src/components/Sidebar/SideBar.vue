<template>
    <div class="container">
        <div class="logo"><img style="height: 200px" src="../../assets/logo.png" /></div>
        <div class="labelContainer">
            <a class="label"><img class="icon" src="../../assets/logo.png" />Tableau de bord</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/logo.png" />Interventions</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/logo.png" />Contrats</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/logo.png" />Réglages</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/logo.png" />Techniciens</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/logo.png" />Clients</a>
        </div>
    </div>
</template>

<script></script>

<style scoped>
.container {
    height: 100%;
    width: 20%;
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    background-color: #103941;
}

.logo {
    display: flex;
    justify-content: center;
    margin: 15% 0
}

ul,
li {
    text-decoration: none;
}

.labelContainer {
    margin-left: 10%;
}

.label {
    color: white;
    font-weight: 600;
    font-size: 22px;
    margin-top: 5%;
    transition: .3s ease-in-out;
    cursor: pointer;
    padding: 4% 7% 4% 3%;
    margin: 5% 0;
    border-radius: 20px;
}

.label:hover {
    background-color: #191919;
}

.icon {
    height: 20px;
    position: relative;
    left: 0;
    margin: 0 2%;
    margin-right: 3%;
}
</style>