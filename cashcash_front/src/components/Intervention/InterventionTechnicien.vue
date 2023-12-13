<template>
    <div class="interventionContainer">
        <div class="intervention">
            <div class="left contentBlock">
                <h1>Réparation de chaudière {{ time }}</h1>
                <p>57 rue des peupliers - 15 km - aujourd'hui - Auchan</p>
            </div>
            <div class="right contentBlock df">
                <!-- <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a> -->
                <a class="roundButton df" @click="commentOpen = !commentOpen; timeOpen=false;"><img src="../../assets/Icons/comment.svg" /></a>
                <a class="roundButton df" @click="timeOpen = !timeOpen;commentOpen=false;"><img src="../../assets/Icons/hourglass.svg" /></a>
            </div>
        </div>
        <div v-if="commentOpen">
            <a>Commentaire</a>
            <input type="text">
        </div>
        <div v-if="timeOpen">
            <a>Temps</a>
            <input v-model="time" type="time" step="300">
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
            commentOpen: false,
            timeOpen: false,
            time: null
        };
    },
    components: {}
});
</script>

<style scoped>
.interventionContainer {
    margin-left: 3%;
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
    font-size: 20px;
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

img {
    width: 45px;
}
</style>