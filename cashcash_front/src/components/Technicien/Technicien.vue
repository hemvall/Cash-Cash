<template>
    <div class="interventionContainer">
        <div class="intervention">
            <div class="left contentBlock">
                <div style="display: flex; align-items: center; font-size: 15px;">
                    <h1>Antoine Blanquaert</h1><a class="technicienLabel">Agence de Lille</a>
                </div>
            </div>
            <div class="right contentBlock df">
                <div @click="EditOpen = !EditOpen">
                    <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a>
                </div>
            </div>
        </div>
        <div v-if="EditOpen" style="margin-top: 2%;">
            <a>Prénom</a>
            <input class="inputForm" type="string" />
            <a>Nom</a>
            <input class="inputForm" type="string" />

        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            address: '57 rue des peupliers',
            placeName: 'Auchan Leers',
            date: 'Aujourdhui',
            distance: '15 km',
            EditOpen: false
        };
    },
    components: {}
});
</script>

<style scoped>
.interventionContainer {
    margin-left: 5%;
    margin-top: 2%;

}

.intervention {
    background-color: #d9d9d9;
    width: 80%;
    padding: 1% 3%;
    border-radius: 25px;
    display: flex;
}

.left,
.right {
    flex: 1;
}

.left {
    flex: 70;
}

.right {
    flex: 30;
}

.contentBlock {
    justify-content: flex-end;
}

.df {
    display: flex;
    align-items: center;
}

.roundButton {
    cursor: pointer;
    border-radius: 50%;
    height: 5vw;
    width: 5vw;
    margin-right: 2%;
    background-color: #103941;
    justify-content: center;
    transition: .3s ease-in-out;
}

.roundButton:hover {
    background-color: #191E26;
}

.technicienLabel {
    background-color: #103941;
    color: white;
    padding: 1% 3%;
    border-radius: 15px;
    margin-left: 2%;
}

img {
    width: 30px;
}

.inputForm {
    margin-right: 2%;
}
</style>