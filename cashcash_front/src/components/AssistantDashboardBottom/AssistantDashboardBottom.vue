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
                <a class="number">15</a><br>
                <a class="cardLabel">Interventions planifiées</a>
            
            </div>
        
        
            <div class="Cards">
                <a class="number">15</a><br>
                <a class="cardLabel">Interventions terminées</a>
            
            </div>
        
        </div>

    </div>

</template>

<script></script>

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