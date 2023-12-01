<template>
    <div class="">
        <SideBar></SideBar>
    </div>
</template>

<script>
import SideBar from '../../components/AssistantDashboardBottom/AssistantDashboardBottom.vue';

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            user: {}
        };
    },
    components: { SideBar }
});
</script>

<style scoped></style>