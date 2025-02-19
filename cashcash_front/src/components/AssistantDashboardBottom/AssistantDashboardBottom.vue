<template>
    <div class="pageWhole">
        <div class="containerTitle">
            <p class="title">
                Ce mois-ci
            </p>
        </div>

        <div class="containerCards">
            <div class="Cards">
            <!-- <p class="number">15</p>
            <p>Interventions planifiées</p> -->
                <a class="number">{{ interventionsPlanifiees.length }}</a><br>
                <a class="cardLabel">Interventions planifiées</a>
            
            </div>
        
        
            <div class="Cards">
                <a class="number">
                    10
                </a><br>
                    <!-- {{ interventionsTerminees.length }} -->
                <a class="cardLabel">Interventions terminées</a>           
            </div>
        
        </div>

    </div>

</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            interventions: [],
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.interventions = [];
            this.loading = true;

            fetch(`${this.$api}/Intervention`)
                .then(r => r.json())
                .then(json => {
                    this.interventions = json;
                    this.loading = false;
                    return;
                });
        },
        interventionsPlanifiees() {
            return this.interventions;
        }, 
        interventionsTerminees() {
            return this.interventions.filter(p => p.etat == "Terminé");
        }, 
    },
    computed:{

    }
});</script>

<style scoped>

.containerTitle{

    color: #103941;
    font-weight: bold;
    font-size: 1.3em;
    display: flex;  
    justify-content: center;    

}

p{
    
    font-size: 1.8em;

}

.Cards{
    
    text-align: center;
    padding: 5%;
    /* padding-left: 5%; */
    /* padding-left: 5%; */
    width: 25%;

}



.containerCards{
    
    color: #103941;
    /* background-color: red; */
    display: flex;  
    justify-content: center;

}

.number{

    font-weight: bold;
    font-size: 9em;
    
}

.pageWhole{

    background-color: #eff0f1;;
    height: 100%;
}

.cardLabel{

    font-weight: bold;
    font-size: 1.6em;

}

</style>