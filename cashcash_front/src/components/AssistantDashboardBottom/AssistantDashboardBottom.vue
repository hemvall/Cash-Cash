<template>
    <div class="dashboardTop">

        <h2 class="title"><strong>Bonjour Louis, </strong></h2>
        <div class="layer">
            <div class="block">Technicien</div>
            <div class="block">Assistants</div>
            <div class="block">Contrats</div>
        </div>
    </div>
</template>

<script></script>

<style scoped>
.dashboardTop {
position: absolute;
top: 0;
left: 0;
right: 0;
height: 47vh;
background-color: #d9d9d9;
}

.title {
    font-size: 28px;
    font-weight: bold;
    margin-left: 5%;
    color: #103941;
    font-family: helvetica !important;
}

.layer {
    display: flex;
    justify-content: space-around;
}

.block {
    width: 25%;
    height: 35vh;
    border-radius: 15px;
    background-color: #EFF0F1;
}
</style>