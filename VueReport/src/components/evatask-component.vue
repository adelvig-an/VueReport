<template>
    <div class="container">
        <div class="row mb-2">
            <div class="col">
                <h5>
                    Задание на оценку
                </h5>
            </div>
            <div class="col-lg-1 col-md-2">
                <label class="form-label">
                    Оценщик
                </label>
            </div>
            <div class="col-md-4">
                <select class="form-select" style="width:100%">
                    <option value="1">Крещенко Олег Александрович</option>
                    <option value="2">Еговцев Вячеслав Алексеевич</option>
                    <option value="3">Авдеев Александр Владимирович</option>
                </select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <h6>Объект оценки</h6>
            </div>
            <div class="col-md-2">
                <a class="btn btn-success" style="float:right">Добавить объект</a>
            </div>
        </div>
        <div class="row mb-2">
            <table class="table table-hover text-nowrap" style="width:100%">
                <thead>
                    <tr>
                        <th></th>
                        <th>
                            Тип объекта
                        </th>
                        <th>
                            Назначение
                        </th>
                        <th>
                            Адрес
                        </th>
                        <th>Оцениваемые права</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Квартира</td>
                        <td>Жилое помещение</td>
                        <td>
                            <input type="text" class="form-control" />
                        </td>
                        <td>
                            <select style="width:100%" class="from-select form-select-sm">
                                <option value="1">Право собственности</option>
                                <option value="2">Право аренды</option>
                                <option value="3">Право требования</option>
                            </select>
                        </td>
                        <td>
                            <a class="btn btn-outline-danger">X</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="row mb-2">
            <div class="col-lg-2 col-md-2">
                <label class="form-label">
                    Цель оценки
                </label>
            </div>
            <div class="col">
                <select class="from-select" style="width:100%">
                    <option value="1">Рыночная стоимость</option>
                    <option value="2">Рыночная и ликвидационная стоимость</option>
                    <option value="3">Ликвидационная стоимость</option>
                </select>
            </div>
        </div>
        <div class="row mb-2">
            <div class="col">
                <label class="form-label">
                    Предпосылки стоимости
                </label>
                <textarea class="form-control" rows="3"></textarea>
            </div>
            <div class="col">
                <label class="form-label">
                    Предполагаемое использование результатов оценки
                </label>
                <textarea class="form-control" rows="3"></textarea>
            </div>
        </div>
        <div class="row mb-2">
            <div class="col-md-6">
                <div class="btn-group" role="group">
                    <input type="radio" value="true" name="radioCastomer" v-model="isCustomer" id="PrivatePerson"
                           class="btn-check" />
                    <label for="PrivatePerson" class="btn btn-outline-primary">Частное лицо</label>
                    <input type="radio" value="false" name="radioCastomer" v-model="isCustomer" id="Organization"
                           class="btn-check" />
                    <label for="Organization" class="btn btn-outline-primary">Организация</label>
                </div>
            </div>
        </div>
        <div class="row mb-2">
            <div class="col">
                <h5 v-if="isCustomer === 'true'">Частное лицо</h5>
                <h5 v-else>Организация</h5>
            </div>
        </div>
        <div class="row text-center justify-content-md-center">

            <div class="col-lg-1">
                <a class="btn btn-outline-primary" style="width:100%">Назад</a>
            </div>
            <div class="col-md-auto"></div>
            <div class="col-lg-1">
                <a class="btn btn-primary" style="width:100%">Далее</a>
            </div>

        </div>
    </div>
</template>

<script>
    export default {
        name: 'evatask-component',
        data() {
            return {
                isCustomer: false
            }
        },
        methods: {
            emailInput(value) {
                this.email = value
            },
            passwordInput(value) {
                this.password = value
            }
        }
    }
</script>
