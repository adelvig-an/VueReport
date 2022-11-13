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
                <a class="btn btn-success" 
                   style="float:right" 
                   data-bs-toggle="modal" 
                   data-bs-target="#exampleModal">
                Добавить объект
                </a>
            </div>

            <!-- Модальное окно -->
            <div class="modal fade" 
                 id="exampleModal" 
                 tabindex="-1" 
                 data-bs-keyboard="false" 
                 data-bs-backdrop="static" 
                 aria-labelledby="exampleModalLabel" 
                 aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <!--<div class="modal-header">
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Закрыть"></button>
                        </div>-->
                        <div class="modal-body">
                            <!-- Тип недвижимости -->
                            <div class="row g-2">
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="true" name="radioRealEstate" id="ResidentialRealEstate"
                                           class="btn-check" />
                                    <label for="ResidentialRealEstate" class="btn btn-outline-primary">Жилая недвижимость</label>
                                </div>
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="false" name="radioRealEstate" id="NonResidentialRealEstate"
                                           class="btn-check" />
                                    <label for="NonResidentialRealEstate" class="btn btn-outline-primary">Нежилая недвижимость</label>
                                </div>
                            </div>
                            <!-- Тип жилой недвижимости -->
                            <div class="row g-2">
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="true" name="radioResidentialRealEstate" id="ResidentialPremises"
                                           class="btn-check" />
                                    <label for="ResidentialPremises" class="btn btn-outline-primary">Жилое помещение</label>
                                </div>
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="false" name="radioResidentialRealEstate" id="ResidentialBuilding"
                                           class="btn-check" />
                                    <label for="ResidentialBuilding" class="btn btn-outline-primary">Жилой дом</label>
                                </div>
                            </div>
                            <!-- Тип жилых помещений -->
                            <div class="row g-2">
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="true" name="radioResidentialPremises" id="Flat"
                                           class="btn-check" />
                                    <label for="Flat" class="btn btn-outline-primary">Квартира</label>
                                </div>
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="false" name="radioResidentialPremises" id="Apartment"
                                           class="btn-check" />
                                    <label for="Apartment" class="btn btn-outline-primary">Апартаменты</label>
                                </div>
                                <div class="col-md-auto p-1">
                                    <input type="radio" value="false" name="radioResidentialPremises" id="PartFlat"
                                           class="btn-check" />
                                    <label for="PartFlat" class="btn btn-outline-primary">Доля</label>
                                </div>
                            </div>
                            <div class="row justify-content-end p-1">
                                <div class="col-md-auto">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
                                </div>
                                <div class="col-md-auto">
                                    <button type="button" class="btn btn-success">Добавить объект</button>
                                </div>
                            </div>
                        </div>
                        <!--<div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
                            <button type="button" class="btn btn-primary">Добавить объект</button>
                        </div>-->
                    </div>
                </div>
            </div>
            <!-- Модальное окно -->

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
