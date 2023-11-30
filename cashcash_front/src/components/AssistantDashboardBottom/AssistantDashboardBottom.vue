<template>
<!-- 
    ici le html
 -->
<!-- {{ myvar }}        
<button @click="changeMyvar">click me ^^</button>
<input  v-model="lblText" type="text">        
 -->

<div class="globalContainer">
    
    <div class="title">
        
        Ce mois -ci

    </div>
    
    <div class="container">
        
        <div class="item">
        <p class="number">15</p> 
        Interventions planifiées
        </div>
    
        <div class="item">
        <p class="number">9</p> 
        Interventions terminées
        </div>

    </div>
    
</div>


</template>

<script>
// ici c'est du vue

import { defineComponent } from 'vue';

export default defineComponent({
    created() {
        // this.fetchData();
    },
    data() {
        return {
            lblText: 'saisir texte',
            user: {},
            myvar:"gecthdhjsl"
        };
    },
    methods: {
        changeMyvar() {
            this.myvar = this.lblText
            // this.myvar = "eheh";
        }
    },
});


</script>

<style scoped>

.title{
    justify-content:center;
    display:flex;
}

.globalContainer{
    height:50vh;
    background-color:#EFF0F1;
    /* display:inline-block; */
    /* width:100%; */
    display: flex;
    justify-content: center;
    flex-direction: column;
}

.container{
    justify-content: center;
    display:flex;
    vertical-align:middle; 
    /* display:inline-block;  */
}

.item{
    margin:0% 2%;
}

.number{
    font-size:2em;
    margin-top:70%;
    display:flex;
    justify-content:center;
}

</style>