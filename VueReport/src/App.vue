<template>
    <nav class="navbar navbar-expand-lg bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Navbar</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <router-link class="nav-link" to="/">Main</router-link>
                        <!--<a class="nav-link active" aria-current="page" href="#">Home</a>-->
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" :to="{ name: 'SecondPage' }">Second</router-link>
                        <!--<a class="nav-link" href="#">Features</a>-->
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/im">Next</router-link>
                        <!--<a class="nav-link" href="#">Pricing</a>-->
                    </li>
                    <li class="nav-item">
                        <a class="nav-link disabled">Disabled</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!--<router-view />-->
    <EvaTaskComponent />
    <!--<EvaTaskListComponent />-->
</template>

<script>
    import EvaTaskComponent from './components/test-component.vue'
    export default {
        name: 'App',
        components: {
            EvaTaskComponent
        }
    }
</script>

<!--<script>
    export default {
        name: 'App',
    }
</script>-->


<!--<script>
    import EvaTaskListComponent from './components/evatasklist-component'
    export default {
        name: 'App',
        components: {
            EvaTaskListComponent
        }
    }
</script>-->

<!--<script>
    import EvaTaskComponent from './components/evatask-component'
    export default {
        name: 'App',
        components: {
            EvaTaskComponent
        }
    }
</script>-->

<!--<script>
    import ObjectLocationComponent from './components/objectcalculationprice-component'
    export default {
        name: 'App',
        components: {
            ObjectLocationComponent
        }
    }
</script>-->
