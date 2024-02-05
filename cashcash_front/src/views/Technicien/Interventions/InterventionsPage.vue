<template>
    <SideBar></SideBar>

        <div class="wholePage">
            <SearchBar></SearchBar>
            <div style="margin-top: 4%;">
                <Intervention></Intervention>
            </div>
        </div>
</template>

<script>
import SideBar from '../../../components/Sidebar/SideBar.vue';
import Intervention from '../../../components/Intervention/InterventionTechnicien.vue';
import SearchBar from '../../../components/Searchbar/SearchBar.vue';

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            user: {},
            interventions: []
        };
    },
    components: { SideBar, Intervention, SearchBar }
});
</script>

<style scoped>
.wholePage{
    margin-left: 20%;
}
</style>