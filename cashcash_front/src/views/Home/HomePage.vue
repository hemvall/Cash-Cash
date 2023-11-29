<template>
    <div class="">
        <SideBar></SideBar>
    </div>
</template>

<script>
import SideBar from '../../components/Sidebar/SideBar.vue'

import { defineComponent } from 'vue';

export default defineComponent({
    created() {
        this.fetchData();
    },
    data() {
        return {
            user: {}
        };
    },
    components: { SideBar },
    methods: {
        fetchData() {
            this.user = {};
            this.loading = true;

            fetch(`${this.$api}/users/${localStorage.getItem('userId')}`)
                .then(r => r.json())
                .then(json => {
                    this.user = json;
                    this.loading = false;
                    return;
                });
        }
    },
});
</script>

<style scoped></style>