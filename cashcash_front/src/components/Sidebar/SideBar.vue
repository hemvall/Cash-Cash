<template>
    <div class="container">
        <div class="logo" @click="$router.push('/')"><img style="height: 200px" src="../../assets/logo.png" /></div>
        <div class="labelContainer">
            <a class="label" @click="$router.push('/')"><img class="icon" src="../../assets/Icons/dashboard.png" />Tableau de bord</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/Icons/clients.png" />Clients</a><br><br><br>
            <a class="label" @click="$router.push('/techniciens')"><img class="icon" src="../../assets/Icons/technicien.png" />Techniciens</a><br><br><br>
            <a class="label" @click="$router.push('/interventions')"><img class="icon" src="../../assets/Icons/reglages.png" />Interventions</a><br><br><br>
            <a class="label" @click="$router.push('/Contrats')"><img class="icon" src="../../assets/Icons/contrat.png" />Contrats</a><br><br><br>
            <a class="label"><img class="icon" src="../../assets/Icons/reglages.png" />Réglages</a><br><br><br>
            <!-- add Condition if user connected == technicien -->
            <a v-if="$store.state.userConnecte === 'Technicien'" class="label" @click="$router.push('/technicien/1/interventions')"><img class="icon" src="../../assets/Icons/reglages.png" />Mes Interventions</a><br><br><br>
        </div>
    </div>
</template>

<script></script>

<style scoped>
.container {
    height: 100%;
    width: 20%;
    position: fixed;
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
    transition: .3s ease-in-out;
    cursor: pointer;
    display: flex;
    border-radius: 20px;
}

.label:hover {
    
    color: #787878;
}

.icon {
    height: 30px;
    position: relative;
    align-items: center;
    justify-content: center;
    left: 0;
    margin: 0 2%;
    margin-right: 3%;
}
</style>